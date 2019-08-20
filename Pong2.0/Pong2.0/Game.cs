using System;
using Tao.FreeGlut;
using Tao.OpenGl;


namespace Pong2._0
{
    class Game
    {

        static void Main()
        {


            Glut.glutInit();

            Glut.glutInitDisplayMode(Glut.GLUT_SINGLE | Glut.GLUT_RGB);
            Glut.glutInitWindowSize(1024, 650);
            Glut.glutInitWindowPosition(140, 10);
            Glut.glutCreateWindow("PONG 2.0");
            Gl.glClearColor(0f, 0f, 0f, 1.0f);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glFlush();
            Glut.glutMainLoop();
        }

    }

}
