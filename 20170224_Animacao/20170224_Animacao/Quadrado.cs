using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace _20170224_Animacao
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
        public Quadrado(float x, float y, int tamanho)
        {
            this.x = x;
            this.y = y;
            this.tamanho = tamanho;
            velocidadeX = 1;
            velocidadeY = 1;
        }
        public Quadrado(float x, float y,
            int tamanho,
            int velocidadeX,
            int velocidadeY)
        {
            this.x = x;
            this.y = y;
            this.tamanho = tamanho;
            this.velocidadeX = velocidadeX;
            this.velocidadeY = velocidadeY;
        }
        public float x { get; set; }
        public float y { get; set; }
        public int tamanho { get; set; }
        public int velocidadeY { get; set; }
        public int velocidadeX { get; set; }

        public void Render()
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex2f(x, y + tamanho);
            Gl.glVertex2f(x, y);
            Gl.glVertex2f(x + tamanho, y);
            Gl.glVertex2f(x + tamanho, y + tamanho);
            Gl.glEnd();
        }

        public void Colisao(Quadrado outro)
        {
            if (((this.x + this.tamanho > outro.x) &&
                (this.x + this.tamanho < outro.x + outro.tamanho)) &&
                ((this.y >= outro.y && this.y < outro.y + outro.tamanho) ||
                (this.y + this.tamanho > outro.y &&
                this.y + this.tamanho < outro.y + outro.tamanho)))
            {
                outro.velocidadeX = -outro.velocidadeX;
                this.velocidadeX = -this.velocidadeX;
                this.x = outro.x - this.tamanho;
            }
            else
            if (((this.x < outro.x + outro.tamanho) &&
                (this.x + tamanho > outro.x)) &&
                ((this.y > outro.y && this.y < outro.y + outro.tamanho) ||
                (this.y + this.tamanho > outro.y &&
                this.y + this.tamanho < outro.y + outro.tamanho)))
            {
                outro.velocidadeX = -outro.velocidadeX;
                this.velocidadeX = -this.velocidadeX;
                outro.x = this.x - outro.tamanho;
            }

            if (((this.y + this.tamanho > outro.y) &&
                (this.y + this.tamanho < outro.y + outro.tamanho)) &&
                ((this.x >= outro.x && this.x < outro.x + outro.tamanho) ||
                (this.x + this.tamanho > outro.x &&
                this.x + this.tamanho < outro.x + outro.tamanho)))
            {
                outro.velocidadeY = -outro.velocidadeY;
                this.velocidadeY = -this.velocidadeY;
                this.y = outro.y - this.tamanho;
            }
            else
            if (((this.y < outro.y + outro.tamanho) &&
                (this.y + tamanho > outro.y)) &&
                ((this.x > outro.x && this.x < outro.x + outro.tamanho) ||
                (this.x + this.tamanho > outro.x &&
                this.x + this.tamanho < outro.x + outro.tamanho)))
            {
                outro.velocidadeY = -outro.velocidadeY;
                this.velocidadeY = -this.velocidadeY;
                outro.y = this.y - outro.tamanho;
            }
        }

        public void Mover()
        {
            this.x += this.velocidadeX;
            this.y += this.velocidadeY;
        }

        public void ColisaoJanela(float alturaJanela,
                                  float larguraJanela)
        {
            if (this.x > larguraJanela - this.tamanho || this.x < 0)
                this.velocidadeX = -this.velocidadeX;
            if (this.y > alturaJanela - this.tamanho || this.y < 0)
                this.velocidadeY = -this.velocidadeY;

            if (this.x > larguraJanela - this.tamanho)
                this.x = larguraJanela - this.tamanho - 1;

            if (this.y > alturaJanela - this.tamanho)
                this.y = alturaJanela - this.tamanho - 1;

            if (this.x < 0) { this.x = 0; }

            if (this.y < 0) { this.y = 0; }
        }
    }
}
