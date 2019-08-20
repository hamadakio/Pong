using System;
using System.Collections.Generic;
using System.Text;

namespace Pong2._0.Objetos
{
    static class Cor
    {
        static float[] rgb = new float[3];

        static float[] Preto()
        {
            for (int i = 0; i < rgb.Length; i++)
            {
                rgb[i] = 0.0f;
            }

            return rgb ;
        }

        static float[] Branco()
        {
            for (int i = 0; i < rgb.Length; i++)
            {
                rgb[i] = 1.0f;
            }

            return rgb;
        }

    }
}
