using System;
using System.Collections.Generic;
using System.Text;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Pong2._0.Objetos
{
    class Poligono : Objeto
    {
        float SizeX, SizeY;

        public Poligono(float x, float y, float sizeX , float sizeY, float[] cores) : base(x, y, cores)
        {
            SizeX = sizeX;
            SizeY = sizeY;
        }



        public override void Render()
        {
            Gl.glColor3f(Cores[0], Cores[1], Cores[2]);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(X,Y);
            Gl.glVertex2f(X + SizeX, Y);
            Gl.glVertex2f(X + SizeX, Y + SizeY);
            Gl.glVertex2f(X, Y + SizeY);
            
            Gl.glEnd();
        }


        public void Colisao(Objeto outro)
        {
            //if (X + Size > outro.X)
            //{

            //}

        }
    }
}
