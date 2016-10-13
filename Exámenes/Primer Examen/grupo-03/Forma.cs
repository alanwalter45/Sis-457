using System;
using System.Drawing;

namespace grupo_03
{

    enum Figuras:byte
    {
        cuadrado,
        rectangulo,
        triangulo,
        circunferencia
    }

    class Forma
    {
        public Figuras Figura { get; set; }
        public Bitmap Formula { get; set; }
        public byte CantidadParametros { get; set; }

        public float Calcular(Figuras figura, params float[] parametro)
        {
            float resultado = 0;
            switch (figura)
            {
                case Figuras.cuadrado:
                    resultado = parametro[0]*parametro[0] ;  break;
                case Figuras.rectangulo:
                    resultado = parametro[0]*parametro[1] ;  break;
                case Figuras.triangulo:
                    resultado = parametro[0]*parametro[1]/2 ;  break;
                case Figuras.circunferencia:
                    resultado = (float)(Math.PI * parametro[0]) ;  break;
            }
            return resultado;
        }        
    }

}