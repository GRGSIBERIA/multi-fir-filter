#include "MultipleFir.h"

#pragma comment(lib, "opengl32.lib")

int main(int argc, char* argv[])
{
	GLFWwindow* window = fir::GLInit(640, 480, "Multiple FIR");

	glClearColor(1.f, 1.f, 1.f, 0.f);

	while (glfwWindowShouldClose(window) == GL_FALSE)
	{
		glClear(GL_COLOR_BUFFER_BIT);

		glfwSwapBuffers(window);
		glfwWaitEvents();
	}
	glfwTerminate();

	return 1;
}