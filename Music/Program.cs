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
        public virtual void Afina()
        {
            Console.WriteLine("{0}, afina su instrumento",nombre);
        }
    }
    class Baterista:Musico
    {
        private string bateria;
        public Baterista(string nombre, string bateria):base(nombre)
        {
            this.bateria=bateria;
        }
        public override void Afina()
        {
            Console.WriteLine("{0}, Afina su {1}",nombre,bateria);
        }
    }
    class Guitarrista:Musico
    {
        private string guitarra;
        public Guitarrista(string nombre, string guitarra):base(nombre)
        {
            this.guitarra=guitarra;
        }
        public override void Afina()
        {
            Console.WriteLine("{0}, Afina su {1}",nombre,guitarra);
        }
    }
    class Bajista:Musico
    {
        private string bajo;
        public Bajista(string nombre,string bajo):base(nombre)
        {
            this.bajo=bajo;
        }
        public override void Afina()
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
            Guitarrista Slash = new Guitarrista("Slash","Gibson");
            Slash.Saluda();
            Slash.Afina();
            Console.WriteLine("\n");
            Guitarrista Cota = new Baterista("Cota","Gibson");
            Slash.Saluda();
            Slash.Afina();
            Console.WriteLine("\n");

            //Lista
            List<Musico> grupo = new List<Musico>();
            grupo.Add(Tom);
            grupo.Add(Flea);
            grupo.Add(Slash);
            foreach(Musico m in grupo)
            {
                m.Saluda();
                m.Afina();
            }
        }
    }
}
