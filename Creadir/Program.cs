using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoF
{
    class Producto 
    {
        public string codigo,descripcion;
        public double precio;
        public int Departamento,Likes;
        public Producto(string c, string d, double p)
        {
            codigo = c;
            descripcion = d; 
            precio = p;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("AQW ","Lapiz Azul #2",12.23d,1,0));
            productos.Add(new Producto("AQW ","Lapiz  Verde #2",12.23d,1,0));
            productos.Add(new Producto("AQW ","Pluma Azul #2",22.23d,2,0));
            productos.Add(new Producto("AQW ","Borrador Azul #2",22.23d,3,0));

            FileStream fs = new FileStream(@"productos.txt",FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0}|{1}|{2}",p.codigo,p.descripcion,p.precio);
                /*txtOut.Write(p.descripcion + " ");
                txtOut.WriteLine(p.precio);*/

            }
            txtOut.Close();
            Console.WriteLine("Archivo Grabado\n"+"Revise su archivo de Texto.\nPulse cualquier tecla...");
            Console.ReadKey();
        
            List<Producto> productos_leidos = new List<Producto>();

            using( StreamReader sr = new StreamReader("productos.txt"))
            {
                string line = "";
                while( (line = sr.ReadLine()) != null)//No llegaremos al final del archivo
                {
                    string[] columnas = line.Split("|");
                    //Console.WriteLine(columnas[0]);
                    productos_leidos.Add(new Producto(columnas[0],columnas[1],Double.Parse(columnas[2])));
                }
            }
            foreach(Producto p in productos_leidos)
            {
                Console.WriteLine("{0}|{1}|{2}",p.codigo,p.descripcion,p.precio);
            }
            /*string texto = "Hola,hay,sfdas,sadf,asd,gfasda";
            string [] cadenas = texto.Split(",");
            Console.WriteLine(cadenas[1]);*/

        }
    }
}