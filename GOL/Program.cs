using System;
using System.Collections.Generic;

namespace GOL
{
    enum Estado {
        viva, muerta
    }
    class Celula
    {
        public Estado estado_actual, estado_siguiente;
        public short Renglon, Columna;   
        public Tablero tablero;
        public Celula (Estado inicial, Tablero tablero, short Renglon, short Columna)
        {
            estado_actual= inicial;
            this.tablero= tablero;
            this.Renglon= Renglon;
            this.Columna= Columna;
        }
    }
    class Tablero
    {
        private List<List<Celula >>   grid;
        public Tablero(){
            grid = new List<List<Celula>>(); 
            grid[0].Add(new Celula(Estado))

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("▒▒▓▒▒▒▒▒▒");
        }
    }
}
