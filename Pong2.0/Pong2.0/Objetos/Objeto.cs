using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;

namespace Pong2._0.Objetos
{
    abstract class Objeto
    {

        public float X { get; set; }
        public float Y { get; set; }
        public float Size { get; private set; }
        public float[] Cores = new float[3];

        protected Objeto(float x, float y, float size, float[] cores)
        {
            X = x;
            Y = y;
            Size = size;
            Cores = cores;
        }

        protected Objeto(float x, float y, float[] cores)
        {
            X = x;
            Y = y;
            Cores = cores;
        }

        protected Objeto()
        {
        }

        public abstract void Render();

    }
}
