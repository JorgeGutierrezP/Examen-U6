using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EXAMENU5
{
    internal class Program
    {
        class InventarioAmazon
        {
            //campos 
            public string Nombre, Descripcion;
            public int CantidadStock;
            public float Precio;

            

            public void Compra()
            {
                try
                {
                    //captura 
                    Console.WriteLine("\n***Compra***");
                    Console.Write("\nIngresar el nombre del producto: ");
                    Nombre = Console.ReadLine();
                    Console.Write("\nIngresar descripción: ");
                    Descripcion = Console.ReadLine();
                    Console.Write("\nIngresar cantidad en stock: ");
                    CantidadStock = int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese el precio: ");
                    Precio = float.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("\nError: " + e.Message);
                    Console.WriteLine("\nRuta: " + e.StackTrace);

                }
                finally
                {
                    Console.Write("\nPresione ENTER para terminar la escritura de datos y regresar al menú");
                    Console.ReadKey();
                }
                
            }
            

        }
        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter("Productos.txt", true);
            //si el archivo no existe lo creará
            //si ya existe, escribirá en él
            //true es para agregar y no para sobreescribir

            int opcion;

            //objeto 
            InventarioAmazon IA = new InventarioAmazon();
            //menu de opciones
            do
            {
                Console.Clear();
                Console.WriteLine("\n***Inventario***");
                Console.WriteLine("1 Comprar ");
                Console.WriteLine("2 Limpiar compra");
                Console.WriteLine("3 Salida del programa");
                Console.Write("\nQue opción desea: ");
                opcion = Int16.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IA.Compra();
                        sw.WriteLine(IA.Nombre+" "+IA.Descripcion+" "+IA.CantidadStock+" "+IA.Precio);
                        sw.Close();
                        Console.WriteLine("Escribiendo en el archivo.........");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("\nPresione ENTER para salir del programa");
                        Console.ReadKey();
                        break;


                    default:
                        Console.Write("\nEsa opcion no existe!!, Presione ENTER para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 2);
        }
    }
}
