using System.Runtime.CompilerServices;

namespace Practica1Parte6Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            string marca = String.Empty;
            string modelo = String.Empty;
            string color = String.Empty;
            int year ;
            int i;

            Console.WriteLine("Cuantos coches vas a almacenar: ");
            int j = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= j; i++)
            {
                Console.Write("Dame la marca del coche: ");
                marca = Console.ReadLine();
                Console.Write("Dame el modelo del coche: ");
                modelo = Console.ReadLine();
                Console.Write("Dame el color del coche: ");
                color = Console.ReadLine();
                Console.Write("Dame el año de compra: ");
                year = Convert.ToInt32(Console.ReadLine());




                Vehiculo vehiculo = new Vehiculo();
                {
                    vehiculo.FechaCompra = year;
                    vehiculo.Marca = marca;
                    vehiculo.Modelo = modelo;
                    vehiculo.Color = color;

                }

                Console.WriteLine($"Tu coche es : {marca} , {modelo}, {color}, {year} ");
            }

            

            
        }
    }
}