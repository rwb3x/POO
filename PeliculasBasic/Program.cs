using System;

namespace PeliculasBasic
{
    class Pelicula 
    {
        public String Titulo, pais, director;
        public Int16 year; 
    }
    class Program
    {
        static void Main(string[] args)
        {
        Pelicula p1 = new Pelicula();
        p1.SetTitulo("La La Land");
        p1.SetAño(2016); 
        Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
        Pelicula p2 = new Pelicula();
        p2.SetTitulo("Green Book");
        p2.SetAño("2019");
        Console.WriteLine("{0}({1})", p2.GetTitulo(),p2.GetAño());
        }
    }
}
