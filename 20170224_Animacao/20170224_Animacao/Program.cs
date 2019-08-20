using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace _20170224_Animacao
{
    class Program
    {
        //static float x1 = 100.0f;
        //static float y1 = 150.0f;
        //static int rsize = 50;

        //static float xstep = 1.0f;
        //static float ystep = 1.0f;

        static Quadrado q1 = new Quadrado();
        static Quadrado q2 = new Quadrado(200, 300, 50, 2, 2);
        static Quadrado q3 = new Quadrado(600, 0, 50, 5, 3);

        static int execucaoAtual = 0;

        static float windowWidth = 250;
        static float windowHeight = 250;

        static void Desenha()
        {
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);

            //if (execucaoAtual <= 200)
            //{
            //    Gl.glBegin(Gl.GL_QUADS);
            //    Gl.glVertex2f(x1, y1 + rsize);
            //    Gl.glVertex2f(x1, y1);
            //    Gl.glColor3f(0.0f, 0.0f, 1.0f);
            //    Gl.glVertex2f(x1 + rsize, y1);
            //    Gl.glVertex2f(x1 + rsize, y1 + rsize);
            //    Gl.glEnd();
            //}else
            //{
            //    Gl.glBegin(Gl.GL_TRIANGLES);
            //    Gl.glVertex2f(x1, y1 + rsize);
            //    Gl.glVertex2f(x1, y1);
            //    Gl.glColor3f(0.0f, 0.0f, 1.0f);
            //    Gl.glVertex2f(x1 + rsize, y1);
            //   // Gl.glVertex2f(x1 + rsize, y1 + rsize);
            //    Gl.glEnd();
            //}

            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            q1.Render();
            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            q2.Render();
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            q3.Render();

            Glut.glutSwapBuffers();
        }

        static void Timer(int value)
        {
            //Random rnd = new Random();
            //rsize = rnd.Next(10, 100);

            //Console.WriteLine($"Q1: {q1.x},{q1.y}");
            //Console.WriteLine($"Q2: {q2.x},{q2.y}");
            //Console.WriteLine($"Q3: {q3.x},{q3.y}");

            q1.Mover();
            q2.Mover();
            q3.Mover();

            q1.Colisao(q2);
            q1.Colisao(q3);

            q2.Colisao(q3);

            q1.ColisaoJanela(windowHeight, windowWidth);
            q2.ColisaoJanela(windowHeight, windowWidth);
            q3.ColisaoJanela(windowHeight, windowWidth);


            //Console.WriteLine($"{value} -> {x1},{y1}");
            //if (x1 > windowWidth - rsize || x1 < 0)
            //    xstep = -xstep;
            //if (y1 > windowHeight - rsize || y1 < 0)
            //    ystep = -ystep;

            //if (x1 > windowWidth - rsize)
            //    x1 = windowWidth - rsize - 1;

            //if (y1 > windowHeight - rsize)
            //    y1 = windowHeight - rsize - 1;


            //if(x1 < 0)
            //{
            //    x1 = 0;
            //}

            //if (y1 < 0)
            //{
            //    y1 = 0;
            //}

            //x1 += xstep;
            //y1 += ystep;

            execucaoAtual = value;
            Glut.glutPostRedisplay();
            Glut.glutTimerFunc(50, Timer, value + 1);
        }

        static void Inicializa()
        {
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
        }

        static void AlteraTamanhoJanela(int w, int h)
        {
            if (h == 0) h = 1; if (w == 0) w = 1;
            Gl.glViewport(0, 0, w, h);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            if (w <= h)
            {
                windowHeight = 250.0f * h / w;
                windowWidth = 250.0f;
            }
            else
            {
                windowWidth = 250.0f * w / h;
                windowHeight = 250.0f;
            }
            Glu.gluOrtho2D(0.0f, windowWidth, 0.0f, windowHeight);
        }

        static void Main()
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_DOUBLE | Glut.GLUT_RGB);
            Glut.glutInitWindowSize((int)windowWidth, (int)windowHeight);
            Glut.glutInitWindowPosition(10, 10);
            Glut.glutCreateWindow("Anima");
            Glut.glutDisplayFunc(Desenha);
            Glut.glutReshapeFunc(AlteraTamanhoJanela);
            Glut.glutTimerFunc(33, Timer, 1);
            Inicializa();
            Glut.glutMainLoop();
        }


    }
}
