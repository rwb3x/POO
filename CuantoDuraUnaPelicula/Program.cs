using System;

namespace CuantoDuraUnaPelicula
{
    class Duracion
    {
        public int horas;
        public int minutos;
        public int segundos;

        public Duracion()
        {
            int Dur = 0;
            Dur= horas * 3600+ minutos*360+segundos;
        }
    }
    class PrintM
    {
        public static void Minutos(ref Duracion a)
        {
            a.minutos=a.horas*60 + a.minutos+ a.segundos/60;
            Console.WriteLine("{0} minutos",a.minutos);
        }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion a = new Duracion();
            a.horas= 4;
            a.minutos=19;
            a.segundos=56;
            Console.WriteLine("{0}:{1}:{2}",a.horas,a.minutos,a.segundos);
            PrintM.Minutos(ref a);
        }
    }
}
