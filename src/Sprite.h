#ifndef SPRITE_H
#define SPRITE_H

#include <string>
#include <GLFW/glfw3.h>

namespace fir
{
	class Sprite
	{
		GLuint texid;
		GLubyte* buffer;
		uint32_t width, height;
		int depth, colortype, interlacetype;
		std::string filePath;
		GLfloat x, y;

		void Init();		// 初期化関数
		void DrawSprite();	// 描画関数の本体

	public:
		Sprite(const char* path, GLfloat initX, GLfloat initY);
		
		template <int initX, int initY>
		Sprite(const char* path);

		virtual ~Sprite();

		// 描画関数
		void Draw();

		void Move(GLfloat tx, GLfloat ty);
	};

	template<int initX, int initY>
	inline Sprite::Sprite(const char * path)
		: filePath(path), x(initX), y(initY)
	{
		Init();
	}
}

#endif