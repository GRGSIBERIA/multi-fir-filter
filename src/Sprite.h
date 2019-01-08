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

		void Init();		// ‰Šú‰»ŠÖ”
		void DrawSprite();	// •`‰æŠÖ”‚Ì–{‘Ì

	public:
		Sprite(const char* path);

		virtual ~Sprite();

		// •`‰æŠÖ”
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