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
        const string FileBin = "productos.bin";
        const string FileText ="productos.txt";
        public static void Escritura_archivoText(string archivo, List<Producto> productos)
        {
            FileStream fs = new FileStream(@"productos.txt",FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);

            foreach(Producto p in productos)
            {
                txtOut.WriteLine("{0}|{1}|{2}|{3}|{4}",p.codigo,p.descripcion,p.precio,p.Departamento,p.Likes);
            }
            txtOut.Close();
        }
        public static void Escritura_ArchivoBin(string archivo, List<Producto> productos)
        {
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate,FileAccess.Write);
            BinaryWriter binOut = new BinaryWriter(fs);

            foreach (Producto p in productos)
            {
                binOut.Write(p.codigo);
                binOut.Write(p.descripcion);
                binOut.Write(p.precio);
                binOut.Write(p.Departamento);
                binOut.Write(p.Likes);
            }
            binOut.Close();        
        }

        public static List<Producto> Lectura_archivoText(string archivo)
        {
            List<Producto> productos_leidos = new List<Producto>();
            using( StreamReader sr = new StreamReader(FileText))
            {
                string line = "";
                while( (line = sr.ReadLine()) != null)//No llegaremos al final del archivo
                {
                    string[] columnas = line.Split("|");
                    //Console.WriteLine(columnas[0]);
                    productos_leidos.Add(new Producto(columnas[0],columnas[1], Decimal.Parse(columnas[2]), int.Parse(columnas[3]), int.Parse(columnas[4])));
                }
            }
            return productos_leidos;
        }
        
        public static List<Producto> Lectura_archivoBin(string Archivo)
        {
            List<Producto> leidos_productos = new List<Producto>();
                using (BinaryReader reader = new BinaryReader(File.Open(FileBin, FileMode.Open)))
                {
                    foreach (Producto p in leidos_productos)
                    {
                        p.codigo = reader.ReadString();
                        p.descripcion = reader.ReadString();
                        p.precio = reader.Read();
                        p.Departamento = reader.ReadInt16();
                        p.Likes = reader.ReadInt16();
                        leidos_productos.Add(new Producto(p.codigo,p.descripcion,p.precio,p.Departamento,p.Likes));
                    }
                    reader.Close();
                }
                return leidos_productos;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("AQW","Lapiz Azul #2",3,1,4));
            productos.Add(new Producto("AQW","Lapiz  Verde #2",3,1,6));
            productos.Add(new Producto("AQW","Pluma Azul #2",7,2,1));
            productos.Add(new Producto("AQW","Borrador Azul #2",9,3,3));

            ProductoDb.Escritura_ArchivoBin(@"productos.bin",productos);
              List<Producto> productosb_guardados = ProductoDb.Lectura_archivoBin("productosb.bin");
                    foreach (Producto p in productosb_guardados)
                    {
                        Console.WriteLine("{0} {1} {2} {3} {4}", p.codigo, p.descripcion, p.precio, p.Departamento, p.Likes);
                    }

           /* List<Producto> productos_leidos = new List<Producto>();
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
            foreach(Producto p in productos_leidos)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",p.codigo,p.descripcion,p.precio,p.Departamento,p.Likes);
            }
            Console.WriteLine("Archivo Grabado\n"+"Revise su archivo de Texto.\nPulse cualquier tecla...\n");
            Console.ReadKey();*/

        }
    }
}
