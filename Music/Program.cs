using System;
using System.Collections.Generic;

namespace Music
{
    class Musico
    {
        protected string nombre;
        public Musico(string n)
        {
            nombre = n;
        }
        public void Saluda()
        {
            Console.WriteLine("Hola,Soy {0}",nombre);
        }
        public void Afina()
        {
            Console.WriteLine("{0}, afina su instrumento",nombre);
        }
    }
    class Bajista:Musico
    {
        private string bajo;
        public Bajista(string nombre,string bajo):base(nombre)
        {
            this.bajo=bajo;
        }
        public new void Afina()
        {
            Console.WriteLine("{0}, Afina su {1}",nombre,bajo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Musico Tom= new Musico("Tom");
            Bajista Flea= new Bajista("Flea","Fender");
            Tom.Saluda();
            Flea.Saluda();
            Tom.Afina();
            Flea.Afina();
        }
    }
}
