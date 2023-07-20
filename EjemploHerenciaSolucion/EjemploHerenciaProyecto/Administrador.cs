using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerenciaProyecto
{
    public class Administrador : Empleado
    {
        public Administrador()
        {
            
        }

        public Administrador(string Nombre) : base(Nombre)
        {
        }

        public override string ToString()
        {
            return $"[Administrador .Nombre: {Nombre} ]";
        }
    }
}