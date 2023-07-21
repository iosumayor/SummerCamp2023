using System;///Console utiliza Syste,

namespace EjemploHerenciaProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Empleado juan = new Empleado("Juan");

            Administrador maria = new Administrador("Maria",true);

            Administrador pedro = new Administrador("Pedro", false);

            Empleado luisito = new Trabajador("luisito", "tarde");

           Empleado luis = new Externo("Luis", new Empresa("Tracasa"));

            juan.Jefe = maria;

            Object Jose = new Trabajador("jose" ,"mañanas");


            


            var lista = new List<Empleado>()
            {
                juan,maria,pedro,luisito, luis,
            };


            IEnumerable<Empleado> listaEmpleadosJ = from empleado in lista
                                                    where empleado.Nombre.StartsWith("J")
                                                    orderby empleado.Nombre
                                                    select empleado;

            foreach (var empleado in lista) {

                if (empleado.Nombre.StartsWith("J"))
                {
                    Console.WriteLine(empleado.Nombre);
                    ///empleado.CalculoVacaciones;
                    
                }

                


            }


            try
            {
                if (maria.TienePlazaParking())
                {
                    Console.WriteLine(" Maria " +maria.PlazaParking());
                }
            }
            
            catch (ErrorBaseDatosExcepcion ex)
            {
                Console.WriteLine(ex.mensaje + " " +ex.fechaHoraExcepcion);
            }


            try
            {
                if (pedro.TienePlazaParking())
                {
                    Console.WriteLine(" Pedro " + pedro.PlazaParking());
                }
            }

            catch (ErrorBaseDatosExcepcion ex)
            {
                Console.WriteLine(ex.mensaje + " " + ex.fechaHoraExcepcion);
            }










            Console.WriteLine(juan);
            Console.WriteLine(maria);
            ///Console.WriteLine(Jose);
            ///Console.WriteLine(pedro);
            ///Console.WriteLine(luis.ToString());
            

        }
    }
}