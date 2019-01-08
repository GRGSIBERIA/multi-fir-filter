#ifndef SPRITE_H
#define SPRITE_H

#include <string>
#include <GLFW/glfw3.h>

namespace fir
{
	class Sprite
	{
		GLuint id;
		GLubyte *buffer;
		uint32_t width, height;
		int depth, colortype, interlacetype;
		std::string filePath;

		void Init();

	public:
		Sprite(const char* path, GLuint tid);
	};
}

#endif