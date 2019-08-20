using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;

namespace Pong2._0.Objetos
{
    class Retangulo : Objeto
    {
        public Retangulo(float x, float y, float size, float[] cores) : base(x, y, size, cores){}


        public override void Render()
        {
            float X2 = X + (Size * 2);
            float Y2 = Y + Size;

            Gl.glRectf(X,Y,X2,Y2);
        }
    }
}
