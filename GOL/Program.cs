﻿using System;
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
        private Tablero tablero1;
        public Celula (
            Estado inicial, Tablero tablero, short Renglon, short Columna)
        {
            estado_actual= inicial;
            this.tablero1= tablero;
            this.Renglon= Renglon;
            this.Columna= Columna;
        }

        private Tablero Tablero1 { get => tablero1; set => tablero1 = value; }

        public void print()
        {
        if (this.estado_actual = this.viva)
        {
            
        }
        
        }
    class Tablero
    {
        private List<List<Celula >>   grid;
        public Tablero(){
            grid = new List<List<Celula>>(); 
            grid[0].Add(new Celula(Estado.viva, this,0,0));
            grid[0].Add(new Celula(Estado.muerta, this,0,1));
            grid[0].Add(new Celula(Estado.muerta, this,0,2));

            grid[1].Add(new Celula(Estado.muerta, this,0,0));
            grid[1].Add(new Celula(Estado.viva, this,0,1));
            grid[1].Add(new Celula(Estado.muerta, this,0,2));

            grid[2].Add(new Celula(Estado.muerta, this,0,0));
            grid[2].Add(new Celula(Estado.muerta, this,0,1));
            grid[2].Add(new Celula(Estado.viva, this,0,2));
        }
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
