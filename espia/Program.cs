﻿using System;

namespace espia
{
    class Persona
    {
        public string nombre, apellido;
        public Persona()
        {
            nombre = "Fulano";
            apellido= "De Tal";
        }
    }
    class Anonymous
    {
        public static void anonimiza(Persona p)
        {
            p.nombre = "xxxxxxxxxxx";
            p.apellido= "xxxxxxxxxxx";
        }
    }
    class Duplicador
    {
        public void duplica(int x)
        {
            x = x*2;
        }    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Console.WriteLine(p.nombre);
            Anonymous.anonimiza(p);
            Console.WriteLine(p.nombre);
            Duplicador dup = new Duplicador();
            dup.duplica(1);

            int x = 2;
            dup.duplica(x);

            Console.WriteLine("El valor es: {0}",x);
            
        }
    }
}
