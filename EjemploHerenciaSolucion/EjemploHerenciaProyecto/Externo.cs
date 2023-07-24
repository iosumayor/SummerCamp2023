using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaProyecto
{
    public class Externo : Empleado
    {

        
        public Externo(string nombre, Empresa empresa) : base(nombre)
        {
            
            
            Empresa = empresa;
        }

        public Empresa Empresa { get; }

        public override string ToString()
        {
            return $"[Trabajador .Nombre : {Nombre}  y trabaja en : {Empresa?.Nombre.ToString()}]";
        }

    }
}
