using System;
using System.IO;
using System.Collections.Generic;

namespace creadir
{
    class Producto 
    {
        public string codigo,descripcion;
        public double precio;

        public Producto(string c,string d,double p)
        {
            codigo = c; descripcion = d; precio = p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("AQW","Lapiz Azul w2",12.23d));
            productos.Add(new Producto("AQW","Lapiz  Verdew2",12.23d));
            productos.Add(new Producto("AQW","Pluma Azul w2",22.23d));
            productos.Add(new Producto("AQW","Borrador Azul w2",22.23d));

            FileStream fs = new FileStream(@"productos.txt",FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0}--{1}--{2}",p.codigo,p.descripcion,p.precio);
                /*txtOut.Write(p.descripcion + " ");
                txtOut.WriteLine(p.precio);*/

            }
            txtOut.Close();
            Console.WriteLine("Archivo Grabado");
            Console.ReadKey();

            List<Producto> productos_leidos = new List<Producto>();

            using( StreamReader sr = new StreamReader("productos.txt"))
            {
                string line = "";
                while( (line = sr.ReadLine()) != null)//No llegaremos al final del archivo
                {
                    string[] columnas = line.Split("--");
                    //Console.WriteLine(columnas[0]);
                    productos_leidos.Add(new Producto(columnas[0],columnas[1],Double.Parse(columnas[2])));
                }
            }
            foreach(Producto p in productos_leidos)
            {
                Console.WriteLine("{0}{1}{2}",p.codigo,p.descripcion,p.precio);
            }
            /*string texto = "Hola,hay,sfdas,sadf,asd,gfasda";
            string [] cadenas = texto.Split(",");
            Console.WriteLine(cadenas[1]);*/

        }
    }
}