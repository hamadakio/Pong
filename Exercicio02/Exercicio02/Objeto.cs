using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace BG_10_03_2017
{
    class Objeto
    {
        public float xf { get; set; }
        public float yf { get; set; }
        public float tamanho { get; set; }
     

        private float r { get; set; }
        private float g { get; set; }
        private float b { get; set; }



        public Objeto(float xf, float yf, float tamanho, float r, float g, float b)
        {
            this.xf = xf;
            this.yf = yf;
            this.tamanho = tamanho;


            this.r = r;
            this.g = g;
            this.b = b;


        }

        //public Objeto(float xf, float yf, float tamanho, float r, float g)
        //{
        //    this.xf = xf;
        //    this.yf = yf;
        //    this.tamanho = tamanho;


        //    this.r = r;
        //    this.g = g;
            

        //}

        public void RenderObjeto(int Tipo , int num)
        {
            Gl.glColor3f(this.r, this.g, this.b);

            if (Tipo == Gl.GL_QUADS && num ==1)
            {
                Gl.glBegin(Tipo);


                Gl.glVertex2f(xf, yf);
                Gl.glVertex2f(xf + 2 * tamanho, yf);

                Gl.glVertex2f(xf + 2 * tamanho, yf + tamanho);
                Gl.glVertex2f(xf, yf + tamanho);

                Gl.glEnd();
            }
            else if (Tipo == Gl.GL_POLYGON && num == 1)
            {

                Gl.glBegin(Tipo);


                Gl.glVertex2f(xf, yf);
                Gl.glVertex2f(xf + 5, yf);

                Gl.glVertex2f(xf + 5, yf + 2 * tamanho);
                Gl.glVertex2f(xf, yf + 2 * tamanho);

                Gl.glEnd();
            }
            else if (Tipo == Gl.GL_QUADS && num == 2)
            {

                Gl.glBegin(Tipo);


                Gl.glVertex2f(xf, yf);
                Gl.glVertex2f(xf +tamanho, yf);

                Gl.glVertex2f(xf +tamanho, yf + tamanho);
                Gl.glVertex2f(xf, yf + tamanho);

                Gl.glEnd();


            }




        }









    }
}
