using System;

namespace PeliculasBasic
{
    class Pelicula 
    {
        public String Titulo,Pais,Director;
        public Int16 Año; 
    }
    class Program
    {
        static void Main(string[] args)
        {
        Pelicula p1 = new Pelicula();
        p1.Titulo="La La Land";
        p1.Año=2016; 
        p1.Pais="USA";
        p1.Director="Austin Gorg";
        Console.WriteLine("{0}({1})", p1.Titulo, p1.Año);
        Pelicula p2 = new Pelicula();
        p2.Titulo="Green Book";
        p2.Año=2019;
        p2.Director="Peter Farrelly";
        Console.WriteLine("{0}({1})", p2.Titulo,p2.Año);
        }
    }
}
