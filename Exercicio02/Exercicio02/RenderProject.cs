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
    class RenderProject
    {
        private Objeto Player { get; set; }
        private Objeto t1 { get; set; }
        private Objeto t2 { get; set; }
        private Objeto t3 { get; set; }
        private Objeto t4 { get; set; }
        private Objeto t5 { get; set; }
        private Objeto t6 { get; set; }

        

        private Eventos evt;
        private static string texto;
        public static bool inicio;

        // private string texto { get; set; }

        public RenderProject(Objeto player,Objeto t1, Objeto t2, Objeto t3, Objeto t4, Objeto t5,Objeto t6,Eventos evt)
        {
            this.Player = player;
            this.t1 = t1;
            this.t2 = t2;
            this.t3 = t3;
            this.t4 = t4;
            this.t5 = t5;
            this.t6 = t6;
            this.evt = evt;            
        }


        public void Desenha()
        {
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            Player.RenderObjeto(Gl.GL_QUADS,1);

            t1.RenderObjeto(Gl.GL_QUADS,1);
            t2.RenderObjeto(Gl.GL_POLYGON,1);
            t3.RenderObjeto(Gl.GL_POLYGON, 1);
            t4.RenderObjeto(Gl.GL_POLYGON, 1);
            t5.RenderObjeto(Gl.GL_QUADS,2);



            

            if (!inicio)
            {
                DesenhaTexto("Placar: " + evt.pontosL + " x " + evt.pontosR);
            }
            else
            {
                t6.RenderObjeto(Gl.GL_QUADS, 1);
                DesenhaTexto("Press Insert");
            }   
            
            


            Gl.glFlush();
        }

        public void DesenhaTexto(string texto)
        {
            //cria uma interferencia (tira um screeenshot faz a interferencia e volta ele )
            Gl.glPushMatrix();
            Gl.glColor3f(1, 1, 1);
            Gl.glRasterPos2f(150,220);
            Glut.glutBitmapString(Glut.GLUT_BITMAP_TIMES_ROMAN_24, texto);
            Gl.glPopMatrix();
        }

        public void DesenhaStart(bool onPlay)
        {
            inicio = onPlay;


        }

        public void MoveMouse(int x, int y)
        {
            texto = String.Format("({0},{1})", x, y);
            Glut.glutPostRedisplay();
        }

    }
}
