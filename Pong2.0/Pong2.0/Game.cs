using System;
using Tao.FreeGlut;
using Tao.OpenGl;
using Pong2._0.Objetos;


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
            Glut.glutDisplayFunc(Desenha);
            Gl.glClearColor(0f, 0f, 0f, 1.0f);

            Glut.glutMainLoop();
        }


        private static void Desenha()
        {
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glOrtho(-512,512,-325,325,0,1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glBegin(Gl.GL_QUADS);

            Gl.glVertex2f(-400f, -250f + 500f);

            Gl.glVertex2f(-400f, -250f);

            Gl.glVertex2f(-400f + 800f, -250f);

            Gl.glVertex2f(-400f + 800f, -250f +500f);

            Gl.glEnd();

            Gl.glColor3f(0f, 0f, 0f);
            Gl.glBegin(Gl.GL_QUADS);

            Gl.glVertex2f(-390f, -240f + 480f);

            Gl.glVertex2f(-390f, -240f);

            Gl.glVertex2f(-390f + 385f, -240f);

            Gl.glVertex2f(-390f + 385f, -240f + 480f);

            Gl.glEnd();

            Gl.glColor3f(0f, 0f, 0f);
            Gl.glBegin(Gl.GL_QUADS);

            Gl.glVertex2f(5f, -240f + 480f);

            Gl.glVertex2f(5f, -240f);

            Gl.glVertex2f(5f + 385f, -240f);

            Gl.glVertex2f(5f + 385f, -240f + 480f);

            Gl.glEnd();


            Gl.glFlush();
        }
    }

}
