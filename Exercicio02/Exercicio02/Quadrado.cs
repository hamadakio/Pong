using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace BG_Animacao1
{
    public class Quadrado
    {


        public Quadrado()
        {

            x = 0;
            y = 0;
            tamanho = 50;
            velocidadeX = 1;
            velocidadeY = 1;

        }


        public Quadrado(float x , float y , int tamanho)
        {

            this.x = x;
            this.y = y;
            this.tamanho = tamanho;
            velocidadeX = 1;
            velocidadeY = 1;

        }



        public Quadrado(float x, float y, int tamanho,int velocidadeX,int velocidadeY)
        {

            this.x = x;
            this.y = y;
            this.tamanho = tamanho;
            this.velocidadeX = velocidadeX ;
            this.velocidadeY = velocidadeY ;

        }



        public float x { get; set; }
        public float y { get; set; }
        public int tamanho { get; set; }
        public int velocidadeX { get; set; }
        public int velocidadeY { get; set; }



        public void Render()
        {

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex2f(x, y + tamanho);
            Gl.glVertex2f(x, y);
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex2f(x + tamanho, y);
            Gl.glVertex2f(x + tamanho, y + tamanho);
            Gl.glEnd();

        }


    

        public void Mover()
        {
            this.x += this.velocidadeX;
            this.y += this.velocidadeY;
        }

        public void ColisaoJanela(float AlturaJanela , float LarguraJanela)
        {

            if (this.x > LarguraJanela - this.tamanho || this.x < 0)
                this.velocidadeX = -this.velocidadeX;

            if (this.y > AlturaJanela - this.tamanho || this.y < 0)
                this.velocidadeY = -this.velocidadeY;


            if (this.x > LarguraJanela - this.tamanho)
                this.x = LarguraJanela - this.tamanho - 1;

            if (this.y > AlturaJanela - this.tamanho)
                this.y = AlturaJanela - this.tamanho - 1;

            if (this.x < 0)
            {
                this.x = 0;
            }

            if (this.y < 0)
            {
                this.y = 0;
            }


        }


    }
}
