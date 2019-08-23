using System;
using System.Collections.Generic;
using System.Text;
using Tao.FreeGlut;
using Tao.OpenGl;
using Pong2._0.Objetos;

namespace Pong2._0.Managers
{
    class GameManager
    {
        public static float Velocidade = 7;
        public static int Round = 0;
        public static int ScoreL = 0, ScoreR = 0;

        public static void GameLoop(int value)
        {
            CheckWin();
            MoverBola();
            Glut.glutPostRedisplay();
            Glut.glutTimerFunc(50,GameLoop , value +1);
        }


        public static void MoverBola()
        {

            Cenario.bola.X += 
             Cenario.bola.Colisao(Cenario.Campo)[0] ? Velocidade : -Velocidade;

            Cenario.bola.Y += 
           Cenario.bola.Colisao(Cenario.Campo)[2] ? Velocidade : -Velocidade;

        }

        public static void CheckWin()
        {
            if (Cenario.bola.X + Cenario.bola.Size >=
                Cenario.Campo.X + Cenario.Campo.Size)
            {
                ScoreL++;
                Round++;
               // Reinicia();
            }
            else if (Cenario.bola.X <= Cenario.Campo.X )
            {
                ScoreR++;
                Round++;
               // Reinicia();
            }
        }

        public static void Reinicia()
        {
            Cenario.bola.X = Round % 2 == 0 ? Velocidade : -Velocidade;
        }

    }

}
