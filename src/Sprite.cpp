#include "Sprite.h"
#include <fstream>
#include <GL/gl.h>

void fir::Sprite::Init()
{
	glGenTextures(1, &id);

	std::ifstream stream(filePath, std::ios::binary);

	const size_t fileSize = static_cast<size_t>(stream.seekg(0, stream.end).tellg());
	const size_t dataSize = fileSize - 8;
	stream.seekg(0, stream.beg);

	stream.read((char*)width, 4);
	stream.read((char*)height, 4);
	stream.read((char*)buffer, dataSize);
	stream.close();

	// ƒeƒNƒXƒ`ƒƒ‚ð“o˜^
	glBindTexture(GL_TEXTURE_2D, id);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);
	glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, &buffer);
}

fir::Sprite::Sprite(const char * path, GLuint tid)
	: filePath(path), id(tid)
{
}
