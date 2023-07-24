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
                    //Console.WriteLine(empleado.Nombre);
                    ///empleado.CalculoVacaciones;
                    
                }

                


            }


            foreach (var empleado in lista) 
            {
                var tipo = empleado.GetType().Name;

                //Console.Write("Introduce el tipo de empleado ");
                //tipo = Console.ReadLine();

                switch (tipo)
                {

                    case "Trabajador":
                        //TODO : Mostrar turno
                        var trabajador = (Trabajador) empleado;
                        Console.WriteLine("El trabajador " + trabajador.Nombre + " tiene un turno de " +trabajador.Turno);
                        break;
                    case "Administrador":
                        //TODO :Mostrar plaza de parking

                        var administrador = (Administrador)empleado;
                        try
                        {
                            if (administrador.TienePlazaParking())
                            {
                                Console.WriteLine(administrador.PlazaParking());
                            }
                        }

                        catch (ErrorBaseDatosExcepcion ex)
                        {
                            Console.WriteLine(ex.mensaje + " " + ex.fechaHoraExcepcion);
                        }
                        /*if (administrador.TienePlazaParking())
                        {
                            Console.WriteLine(administrador.TieneParking);
                        }*/
                        break;
                    case "Externo":
                        var externo = (Externo)empleado;
                        Console.WriteLine("El empleado " +externo.Nombre + " trabaja en " +externo.Empresa?.Nombre);///se pone interrogante por si es nulo y tiene que pasar
                        //TODO : Mostrar nombre de empresa
                        break;
                }
                ///empleado.CalculoVacaciones();
            
            }


            /*try
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
            }*/










            ///Console.WriteLine(juan);
            ///Console.WriteLine(maria);
            ///Console.WriteLine(Jose);
            ///Console.WriteLine(pedro);
            ///Console.WriteLine(luis.ToString());
            

        }
    }
}