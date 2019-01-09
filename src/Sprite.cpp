#include "Sprite.h"
#include <fstream>
#include <GL/gl.h>

void fir::Sprite::Init()
{
	glGenTextures(1, &texid);

	std::ifstream stream(filePath, std::ios::binary);

	// 領域の設定
	const size_t fileSize = static_cast<size_t>(stream.seekg(0, stream.end).tellg());
	const size_t dataSize = fileSize - 8;
	stream.seekg(0, stream.beg);
	buffer = new GLubyte[dataSize];		// 解放は忘れないで

	stream.read((char*)width, 4);
	stream.read((char*)height, 4);
	stream.read((char*)buffer, dataSize);
	stream.close();

	// テクスチャを登録
	glBindTexture(GL_TEXTURE_2D, texid);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);
	glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, &buffer);
}

// スプライトの描画処理本体
void fir::Sprite::DrawSprite()
{
	glBindTexture(GL_TEXTURE_2D, texid);

	glEnable(GL_TEXTURE_2D);
	glEnableClientState(GL_VERTEX_ARRAY);
	glEnableClientState(GL_TEXTURE_COORD_ARRAY);

	glDrawArrays(GL_QUADS, 0, 4);

	glDisableClientState(GL_TEXTURE_COORD_ARRAY);
	glDisableClientState(GL_VERTEX_ARRAY);
	glDisable(GL_TEXTURE_2D);
}

void fir::Sprite::Draw()
{
	const GLfloat vtx[] = {
		x, y,
		x + width, y,
		x + width, y + height,
		x, y + height
	};
	glVertexPointer(2, GL_FLOAT, 0, vtx);

	const GLfloat texuv[] = {
		0.0f, 1.0f,
		1.0f, 1.0f,
		1.0f, 0.0f,
		0.0f, 0.0f
	};
	glTexCoordPointer(2, GL_FLOAT, 0, texuv);

	DrawSprite();
}

void fir::Sprite::Move(GLfloat tx, GLfloat ty)
{
	x += tx;
	y += ty;
}

bool fir::Sprite::IsMouseOver(GLFWwindow* window) const
{
	double cx, cy;
	glfwGetCursorPos(window, &cx, &cy);
	
	switch (collision)
	{
	case CollisionType::Rect:	// 矩形の当たり判定
		return
			(x < cx && cx < x + width) &&
			(y < cy && cy < y + height) ? true : false;

	case CollisionType::Circle:	// 円の当たり判定
		const GLfloat a = x - (GLfloat)cx;
		const GLfloat b = y - (GLfloat)cy;
		const GLfloat ANS = a * a + b * b;
		if (width < height)
		{
			return ANS <= width * width;
		}
		return ANS <= height * height;
	}

	return false;
}

bool fir::Sprite::LeftClick(GLFWwindow* window)
{
	return 
		IsMouseOver(window) && 
		glfwGetMouseButton(window, GLFW_MOUSE_BUTTON_LEFT) == GLFW_PRESS ? true : false;
}

bool fir::Sprite::RightClick(GLFWwindow * window)
{
	return
		IsMouseOver(window) && 
		glfwGetMouseButton(window, GLFW_MOUSE_BUTTON_RIGHT) == GLFW_PRESS ? true : false;
}

bool fir::Sprite::LeftRelease(GLFWwindow * window)
{
	return
		IsMouseOver(window) && 
		glfwGetMouseButton(window, GLFW_MOUSE_BUTTON_LEFT) == GLFW_RELEASE ? true : false;
}

bool fir::Sprite::RightRelease(GLFWwindow * window)
{
	return
		IsMouseOver(window) && 
		glfwGetMouseButton(window, GLFW_MOUSE_BUTTON_RIGHT) == GLFW_RELEASE ? true : false;
}



fir::Sprite::Sprite(const char * path, GLfloat initX, GLfloat initY, CollisionType collision = fir::CollisionType::Rect)
	: filePath(path), x(initX), y(initY), collision(collision)
{
	Init();
}

fir::Sprite::~Sprite()
{
	delete[] buffer;
}
