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

		void Init();		// 初期化関数
		void DrawSprite();	// 描画関数の本体

	public:
		Sprite(const char* path);

		virtual ~Sprite();

		// 描画関数
		void Draw(const int x, const int y);
		template <int x, int y> void Draw();
	};

	template<int x, int y>
	inline void Sprite::Draw()
	{
		Draw(x, y);

		DrawSprite();
	}
}

#endif