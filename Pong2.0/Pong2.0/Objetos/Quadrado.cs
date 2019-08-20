using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;

namespace Pong2._0.Objetos
{
    class Quadrado : Objeto
    {
        public Quadrado(float x, float y, float size, float[] cores) : base(x, y, size,cores) {}

        /// <summary>
        /// "Desenha o objeto a partir do ponto (x,y) em que ele foi instanciado "
        /// </summary>
        public override void Render()
        {
            Gl.glBegin(Gl.GL_QUADS);
            
            Gl.glVertex2f(X,Y);
            Gl.glVertex2f(X + Size, Y);
            
            Gl.glVertex2f(X + Size, Y + Size);
            Gl.glVertex2f(X, Y + Size);

            Gl.glEnd();

        }
    }
}
