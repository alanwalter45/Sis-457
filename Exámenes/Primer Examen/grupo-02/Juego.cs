using System;

namespace grupo_02
{
    class Juego
    {
        public byte NumeroIntentos { get; set; }
        public byte NumeroAdivinar { get; set; }
        public byte NumeroTotalIntentos { get; set; }
        public bool Gano{get;set;}

        public Juego()
        {
            NumeroIntentos = 0;
            Gano = false;          
            NumeroTotalIntentos = 3;
            
            Random r = new Random();
            NumeroAdivinar = r.Next(1, 11);
        }
    }
}