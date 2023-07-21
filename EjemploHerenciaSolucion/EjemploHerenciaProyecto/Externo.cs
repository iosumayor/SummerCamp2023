using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaProyecto
{
    public class Externo : Empleado
    {

        private Empresa empresa;
        public Externo(string nombre, Empresa empresa) : base(nombre)
        {
            this.empresa = empresa;
        }


        public override string ToString()
        {
            return $"[Trabajador .Nombre : {Nombre}  y trabaja en : {empresa.ToString()}]";
        }

    }
}
