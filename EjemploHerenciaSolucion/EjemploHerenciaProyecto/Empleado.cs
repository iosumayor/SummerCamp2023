using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerenciaProyecto
{
    public partial class Empleado
    {
        public string Nombre
        {
            get;
            set;
            
        }

        

        public Empleado(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public Empleado()///clase vacia para poder inicializar
        {

            Nombre = string.Empty;
        }

        protected double diasVacaciones;


        public override string ToString()
        {
            return $"[Empleado. Nombre: {Nombre} ]";
        }
    }

    
}