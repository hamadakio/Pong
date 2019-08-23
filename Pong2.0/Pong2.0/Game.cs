using System;
using Tao.FreeGlut;
using Tao.OpenGl;
using Pong2._0.Objetos;
using Pong2._0.Managers;


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
            Glut.glutTimerFunc(33,GameManager.GameLoop,1);
            Glut.glutDisplayFunc(Desenha);
            Gl.glClearColor(0f, 0f, 0f, 1.0f);

            Glut.glutMainLoop();
        }


        private static void Desenha()
        {
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            //Seta camera orthographic p uma resolucao 1024x650
            Gl.glOrtho(-512,512,-325,325,0,1);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            Cenario.DesenhaCenario();
            

            Gl.glFlush();
        }
    }

}
