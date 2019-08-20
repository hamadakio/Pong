using BG_10_03_2017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Exercicio02
{
    class Eventos
    {

        private Objeto Player { get; set; }
        private Objeto t1 { get; set; }
        private Objeto t2 { get; set; }
        private Objeto t3 { get; set; }
        private Objeto t4 { get; set; }
        private Objeto t5 { get; set; }
       
        public int pontosL { get; set; }
        public int pontosR { get; set; }
        private float VelX { get; set; }
        private float VelY { get; set; }
        public bool Reinicia { get; private set; }
        private int round = 1;

        public Eventos(Objeto player, Objeto t1, Objeto t2, Objeto t3, Objeto t4, Objeto t5)
        {
            this.Player = player;
            this.t1 = t1;
            this.t2 = t2;
            this.t3 = t3;
            this.t4 = t4;
            this.t5 = t5;
            VelX = 7;
            VelY = 7;
         
        }

        public void GerenciaTeclado(byte key, int x, int y)
        {
            var move = "";
            switch (Convert.ToChar(key))
            {
                case 'W':
                case 'w':
                    move = "W";
                    t3.yf += 7;
                    break;
                case 'S':
                case 's':
                    move = "S";
                    t3.yf -= 7;

                    break;
                case 'O':
                case 'o':
                    move = "O";
                    t4.yf += 7;

                    break;
                case 'L':
                case 'l':
                    move = "L";
                    t4.yf -= 7;

                    break;
                case 'G':
                case 'g':
                    

                    break;
            }

          
          


            Glut.glutPostRedisplay();
        }





        public void Colisao(Objeto outro)
        {
            if (t5.xf >= 203)
            {
                if ((t5.xf + t5.tamanho >= outro.xf) &&
                     (t5.yf < outro.yf + (outro.tamanho * 2)) &&
                     (t5.yf + t5.tamanho > outro.yf))
                {
                    VelX = -VelX;
                }
            } 

        }

        public void Colisao2(Objeto outro2)
        {
            if (t5.xf <= 200)
            {

                if ((t5.xf <= outro2.xf) &&
                    (t5.yf < outro2.yf + (outro2.tamanho * 2)) &&
                    (t5.yf + t5.tamanho > outro2.yf))
                {
                    VelX = -VelX;
                }

            }

        }


        public void Reiniciar()
        {

            if (Reinicia)
            {
                t5.xf = 203;
                t5.yf = 113;
                Reinicia = false;
                round++;

                if (round % 2 == 0)
                {
                    VelX = -7;
                }
                else
                {
                    VelX = 7;
                }

            }

        }

        public void ColisaoBarras(Objeto barrinhas)
        {


            if (barrinhas.yf + (barrinhas.tamanho *2) >= 203)
            {
                barrinhas.yf  = 203 - (barrinhas.tamanho * 2);
            } else if (barrinhas.yf <= 23)
            {
                barrinhas.yf = 23;
            }

        }

        public void Mover()
        {
            this.t5.xf += this.VelX;
            this.t5.yf += this.VelY;
        }

        public void ColisaoJanela(float alturaJanela,
                                  float larguraJanela)
        {
            if (this.t5.xf > larguraJanela - this.t5.tamanho || this.t5.xf < 0)
            {
                this.VelX = -this.VelX;
                pontosL += 1;
                Reinicia = true;
            }
            else
            if (this.t5.yf > alturaJanela - this.t5.tamanho || this.t5.yf < 0)
            {
                this.VelY = -this.VelY;

            }
            else
            if (this.t5.xf > larguraJanela - this.t5.tamanho)
            {
                this.t5.xf = larguraJanela - this.t5.tamanho - 1;

            }
            else
            if (this.t5.yf > alturaJanela - this.t5.tamanho)
            {
                this.t5.yf = alturaJanela - this.t5.tamanho - 1;

            }

            if (this.t5.xf < 25)
            {
                this.t5.xf = 25;
                this.VelX = -this.VelX;
                pontosR += 1;
                Reinicia = true;
            }

            if (this.t5.yf < 24)
            {
                this.t5.yf = 24;
                this.VelY = -this.VelY;
            }

            
        }



    }
}

