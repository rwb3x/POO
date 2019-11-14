using System;

class Domino
{
    int num;
    int den;

    public Domino(int Parte1, int Parte2)
    {
        num = Parte1;
        den = Parte2;
    }
    public static Domino operator +(Domino a, Domino b)
    =>a+b;
}

namespace Dominos
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Domino(2,0);
            var b = new Domino(4,1);
            Console.WriteLine( a+b);
        }
    }
}
