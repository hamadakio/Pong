using Exercicio02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace BG_10_03_2017
{
    class Program
    {
        static Eventos evento;
        static Objeto  campo,bola, borda , leftplayer, rightplayer , linhameio , TStart;
        static RenderProject rend;
        public static bool start = false;
        
        public static float tam = 250 , r,g,b=1;

        static void Inicializa()
        {
            

            Gl.glClearColor(0f, 0f, 0f, 1.0f);


            borda = new Objeto(18, 21, 185, 1.0f, 1.0f, 1.0f);
            campo = new Objeto(23, 23, 180, 0.0f, 1.0f, 0.0f);
            bola = new Objeto(200, 113, 10, 1.0f, 0.0f, 1.0f);

           

            leftplayer = new Objeto(36, 30, 50, 1.0f, 0.0f, 0.0f);
            rightplayer = new Objeto(360, 30, 50,  1.0f, 0.0f, 0.0f);
            linhameio = new Objeto(203, 23, 90, 1.0f, 1.0f, 1.0f);


            
            TStart = new Objeto(0, 0, tam, r, g, b);
            




            evento = new Eventos(borda , campo , linhameio, leftplayer, rightplayer, bola);

            rend = new RenderProject(borda, campo, linhameio, leftplayer, rightplayer, bola,TStart, evento);


           

        }



        

        static void AlteraTamanhoJanela(int w, int h)
        {
            // Evita a divisao por zero
            if (h == 0) h = 1;

            // Especifica as dimensões da Viewport
            Gl.glViewport(0, 0, w, h);

            // Inicializa o sistema de coordenadas
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            // Estabelece a janela de seleção (left, right, bottom, top)
            if (w <= h)
                Glu.gluOrtho2D(0.0f, 250.0f, 0.0f, 250.0f * h / w);
            else
                Glu.gluOrtho2D(0.0f, 250.0f * w / h, 0.0f, 250.0f);
        }

        static void TeclasEspeciais(int key, int x, int y)
        {
            if (key == Glut.GLUT_KEY_INSERT)
            {
                start = true;
                rend.DesenhaStart(false);               
            }
            
            Glut.glutPostRedisplay();
        }

        static void Timer(int value)
        {
            if (start)
            {
                evento.Mover();
                evento.Colisao(rightplayer);
                evento.Colisao2(leftplayer);
                evento.ColisaoJanela(203, 383);
                evento.ColisaoBarras(leftplayer);
                evento.ColisaoBarras(rightplayer);
                evento.Reiniciar();
            }
            else if (!start)
            {
                rend.DesenhaStart(true);
                
            }

            

            Glut.glutPostRedisplay();
            Glut.glutTimerFunc(50, Timer, value + 1);
        }


        static void Main()
        {


            Glut.glutInit();
           
            Glut.glutInitDisplayMode(Glut.GLUT_SINGLE | Glut.GLUT_RGB);
            Glut.glutInitWindowSize(500,300);
            Glut.glutInitWindowPosition(10, 10);
            Glut.glutCreateWindow("PONG");
            Inicializa();
            Glut.glutPassiveMotionFunc(rend.MoveMouse);
            Glut.glutTimerFunc(33, Timer, 1);
            Glut.glutDisplayFunc(rend.Desenha);
            Glut.glutReshapeFunc(AlteraTamanhoJanela);
            Glut.glutKeyboardFunc(evento.GerenciaTeclado);
            Glut.glutSpecialFunc(TeclasEspeciais);



            Glut.glutMainLoop();
        }


    }
}

