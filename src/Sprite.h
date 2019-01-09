#ifndef SPRITE_H
#define SPRITE_H

#include <string>
#include <GLFW/glfw3.h>

namespace fir
{
	enum CollisionType {
		Rect,
		Circle
	};

	class Sprite
	{
		const std::string filePath;
		const CollisionType collision;

		uint32_t width, height;
		GLuint texid;
		GLubyte* buffer;
		int depth, colortype, interlacetype;
		GLfloat x, y;
		

		void Init();		// �������֐�
		void DrawSprite();	// �`��֐��̖{��

		bool IsMouseOver(GLFWwindow* window) const;

	public:
		Sprite(const char* path, GLfloat initX, GLfloat initY, CollisionType collision);
		
		template <int initX, int initY>
		Sprite(const char* path);

		virtual ~Sprite();

		// �`��֐�
		void Draw();

		inline void Move(GLfloat tx, GLfloat ty);	// �X�v���C�g�̈ړ�

		virtual bool LeftClick(GLFWwindow* window);		// ���N���b�N
		virtual bool RightClick(GLFWwindow* window);	// �E�N���b�N
		virtual bool LeftRelease(GLFWwindow* window);
		virtual bool RightRelease(GLFWwindow* window);
	};

	template<int initX, int initY>
	inline Sprite::Sprite(const char * path)
		: filePath(path), x(initX), y(initY)
	{
		Init();
	}
}

#endif