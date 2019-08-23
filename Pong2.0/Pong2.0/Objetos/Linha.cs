using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;

namespace Pong2._0.Objetos
{
    class Linha : Objeto
    {
        public Linha(float x, float y, float size, float[] cores) : base(x, y, size, cores)
        {
        }

        public override void Render()
        {
            Gl.glColor3f(Cores[0], Cores[1], Cores[2]);
            //linha cortada
            Gl.glEnable(Gl.GL_LINE_STIPPLE);
            Gl.glLineStipple(7,0xAAAA);
            //largura da linha
            Gl.glLineWidth(3f);
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glVertex2f(X, Y);
            Gl.glVertex2f(X, Y + Size);
            Gl.glEnd();
            Gl.glEnable(Gl.GL_LINE_STIPPLE);
        }
    }
}
