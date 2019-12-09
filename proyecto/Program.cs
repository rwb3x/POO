using System;
using System.IO;
using System.Collections.Generic;

namespace proyecto
{
    class Producto 
    {
        public string codigo,descripcion;
        public decimal precio;
        public int Departamento,Likes;
        public Producto(string c, string d, decimal p, int dd, int l)
        {
            codigo = c;
            descripcion = d; 
            precio = p;
            Departamento = dd;
            Likes = l;
        }
    }
    
    class ProductoDb
    {
        public static void Lectura_archivo(string archivo)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("AQW","Lapiz Azul #2",3,1,4));
            productos.Add(new Producto("AQW","Lapiz  Verde #2",3,1,6));
            productos.Add(new Producto("AQW","Pluma Azul #2",7,2,1));
            productos.Add(new Producto("AQW","Borrador Azul #2",9,3,3));

            FileStream fs = new FileStream(@"productos.txt",FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.Departamento,p.Likes);
                /*txtOut.Write(p.descripcion + " ");
                txtOut.WriteLine(p.precio);*/

            }
            txtOut.Close();
        }

        public static void GetDepartament(int Depto)
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos_leidos = new List<Producto>();

            using( StreamReader sr = new StreamReader("productos.txt"))
            {
                string line = "";
                while( (line = sr.ReadLine()) != null)//No llegaremos al final del archivo
                {
                    string[] columnas = line.Split("|");
                    //Console.WriteLine(columnas[0]);
                    productos_leidos.Add(new Producto(columnas[0],columnas[1], Decimal.Parse(columnas[2]), int.Parse(columnas[3]), int.Parse(columnas[4])));
                }
            }
            Console.WriteLine("Archivo Grabado\n"+"Revise su archivo de Texto.\nPulse cualquier tecla...\n");
            Console.ReadKey();
            foreach(Producto p in productos_leidos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",p.codigo,p.descripcion,p.precio,p.Departamento,p.Likes);
            }

        }
    }
}
