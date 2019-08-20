using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;

namespace Pong2._0.Objetos
{
    abstract class Objeto
    {

        public float X { get; private set; }
        public float Y { get; private set; }
        public float Size { get; private set; }
        public float[] Cores { get; private set; }

        protected Objeto(float x, float y, float size, float[] cores)
        {
            X = x;
            Y = y;
            Size = size;
            Cores = cores;
        }

        public abstract void Render();

        //public virtual void CheckColisao(Objeto outro)
        //{
        //    if ((X + Size) >= )
        //    {

        //    }
        //}

    }
}
