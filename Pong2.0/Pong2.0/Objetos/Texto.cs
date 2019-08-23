using System;
using System.Collections.Generic;
using System.Text;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Pong2._0.Objetos
{
    class Texto : Objeto
    {
        private string Text;

        public Texto(float x, float y,string texto ,float[] cores) : base(x, y, cores)
        {
            Text = texto;
        }

        public override void Render()
        {
            Gl.glPushMatrix();
            Gl.glColor3f(Cores[0], Cores[1], Cores[2]);
            Gl.glRasterPos2f(X, Y);
            Glut.glutBitmapString(Glut.GLUT_BITMAP_TIMES_ROMAN_24, Text);
            Gl.glPopMatrix();
        }
    }
}
