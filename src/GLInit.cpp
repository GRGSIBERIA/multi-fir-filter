#include "MultipleFir.h"

namespace fir
{
	GLFWwindow* GLInit(const int width, const int height, const char* title)
	{
		if (glfwInit() == GL_FALSE)
		{
			std::cerr << "Can't initialize GLFW" << std::endl;
			throw new std::exception("Can't initialize GLFW");
		}

		glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 3);
		glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 2);
		glfwWindowHint(GLFW_OPENGL_FORWARD_COMPAT, GL_TRUE);
		glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);

		GLFWwindow *window = glfwCreateWindow(width, height, title, NULL, NULL);
		if (window == nullptr)
		{
			std::cerr << "Can't create GLFW window." << std::endl;
			glfwTerminate();
			throw new std::exception("Can't create GLFW window.");
		}

		glfwMakeContextCurrent(window);

		return window;
	}
}