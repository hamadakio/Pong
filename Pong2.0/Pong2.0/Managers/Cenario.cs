using System;
using System.Collections.Generic;
using System.Text;
using Pong2._0.Objetos;

namespace Pong2._0.Managers
{
    class Cenario
    {
        public static Poligono BordaCampo = new Poligono(-400f, -250f, 800f, 500f, Cor.Branco());
        public static Poligono Campo = new Poligono(-390f, -240f, 780f, 480f, Cor.Preto());
        public static Linha linha = new Linha(1f, -240f, 480, Cor.Branco());
        public static Quadrado bola = new Quadrado(-6f, -6f, 12f, Cor.Branco());
        public static Poligono player1 = new Poligono(-370f, -20f, 10f, 40f, Cor.Branco());
        public static Poligono player2 = new Poligono(360, -20f, 10f, 40f, Cor.Branco());
        public static Texto Titulo = new Texto(-50f, 270f, "PONG 2.0", Cor.Branco());

        public static void DesenhaCenario()
        {
            BordaCampo.Render();
            Campo.Render();
            linha.Render();
            bola.Render();
            player1.Render();
            player2.Render();
            Titulo.Render();
        }

        public static void DesenhaMenu()
        {

        }


    }
}
