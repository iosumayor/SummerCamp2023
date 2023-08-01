using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjLinq
{
    internal class EjemploOperador1
    {
        public EjemploOperador1()
        {

        }
        internal void Ejecutar()
        {

            // Lista de empleados
            IEnumerable<Empleado> Empleados = new List<Empleado>()         {             new Empleado             {                 Nombre = "Jose",                 Apellidos = "Conde",                 Ciudad = "Madrid",                 Telefono = "123456789",                 Departamento = Departamento.Desarrollo             },             new Empleado             {                 Nombre = "Luis",                 Apellidos = "Castillo",                 Ciudad = "Madrid",                 Telefono = "423456789",                 Departamento = Departamento.Soporte             },             new Empleado             {                 Nombre = "Juan",                 Apellidos = "Nuñez",                 Ciudad = "Barcelona",                 Telefono = "9123456789",                 Departamento= Departamento.RH             },             new Empleado             {                 Nombre = "Maria",                 Apellidos = "Garcia",                 Ciudad = "Valencia",                 Telefono = "8123456789",                 Departamento = Departamento.Admin             }          };


            var empleadosDesarrolloSoporte = Empleados.Where(empleados =>
                                            empleados.Departamento == Departamento.Desarrollo || empleados.Departamento == Departamento.Soporte && empleados.Apellidos.StartsWith("C"))
            .OrderByDescending(empleados => empleados.Nombre).ToList();

            var empleadosDesarrolloSoporteConsulta = (from empleado in Empleados
                                                     where (empleado.Departamento == Departamento.Desarrollo || empleado.Departamento == Departamento.Soporte) && empleado.Apellidos.StartsWith("C")
                                                     orderby empleado.Nombre descending
                                                     select empleado ).ToList();


            //Listado de los telefonos de los empleados de Madrid
            // que contengan en su apellido una "a"
            //ordenado por nombre


            var empleadosTelefonoMadrid = Empleados.Where(e =>
                                                             e.Ciudad == "Madrid" &&
                                                             e.Apellidos.Contains("a"))
                                      .OrderBy(e => e.Nombre)
                                      .Select(e => e.Telefono)
                                      .ToList();


            var empleadosTelefonoMadridSql = (from empleado in Empleados where (empleado.Apellidos.StartsWith("A")) orderby empleado.Nombre ascending select empleado.Telefono.ToList());


            var Empleadosoportelefono1 = (from empleado in Empleados
                                          where (empleado.Apellidos.StartsWith("C"))                                          orderby empleado.Nombre ascending                                          select new { Telefono = empleado.Telefono, Ciudad = empleado.Ciudad }).ToList();


            //Agregar esta lista a los antiguos emplados
            // No se permite el uso de lista.add
            // Se agregan todos de una vez

            var empleadosNuevos = new List<Empleado>
            {
                new Empleado
                {
                    Nombre = "Fabricio",
                    Apellidos = "Cordero",
                    Departamento = Departamento.Desarrollo
                },

                new Empleado
                {
                    Nombre = "Julia",
                    Apellidos = "Lombardo",
                    Departamento = Departamento.Admin
                },
            };


            List<Empleado> empladosAntiguos = Empleados                                           .Select(empleado => empleado)                                           .ToList();            empladosAntiguos.AddRange(empleadosNuevos);

            
            Empleados = Empleados.Concat(empleadosNuevos).ToList();
            
            foreach(var empleadillo in Empleados)//foreach para recorrer todo los empleados
            {
                Console.WriteLine(empleadillo.Nombre);
            }
            

            
        }

        



    }
}
