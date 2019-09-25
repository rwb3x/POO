using System;

namespace espia
{
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
            Console.WriteLine("Hello World!");
            Duplicador dup = new Duplicador();
            dup.duplica(1);

            int x = 2;
            dup.duplica(x);

            Console.WriteLine("El valor es: {0}",x);
            
        }
    }
}
