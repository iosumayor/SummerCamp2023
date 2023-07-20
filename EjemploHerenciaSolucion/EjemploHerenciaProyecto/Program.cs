using System;///Console utiliza Syste,

namespace EjemploHerenciaProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Empleado juan = new Empleado("Juan");

            Administrador maria = new Administrador("Maria");

            juan.Jefe = maria;

            Object Jose = new Trabajador("jose");

            Console.WriteLine(juan);
            Console.WriteLine(maria);
            Console.WriteLine(Jose);

        }
    }
}