using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;

namespace Pong2._0.Objetos
{
    class Quadrado : Objeto
    {
        public Quadrado(float x, float y, float size, float[] cores) : base(x, y, size, cores) { }

        /// <summary>
        /// "Desenha o objeto a partir do ponto (x,y) em que ele foi instanciado "
        /// </summary>
        public override void Render()
        {
            Gl.glColor3f(Cores[0], Cores[1], Cores[2]);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex2f(X, Y);
            Gl.glVertex2f(X + Size, Y);
            Gl.glVertex2f(X + Size, Y + Size);
            Gl.glVertex2f(X, Y + Size);

            Gl.glEnd();

        }

        /// <summary>
        /// retorna verdadeiro ou falso caso tenha colidido left,right,up,down
        /// </summary>
        /// <param name="outro"></param>
        /// <returns></returns>
        public bool[] Colisao(Objeto outro)
        {
            bool[] vector = new bool[4];

            vector[0] = X + Size > outro.X + outro.Size ? true : false;
            vector[1] = Y + Size > outro.Y + Size ? true : false;
            vector[2] = X < outro.X ? true : false;
            vector[3] = Y < outro.Y ? true : false;

            return vector;
        }

    }
}
