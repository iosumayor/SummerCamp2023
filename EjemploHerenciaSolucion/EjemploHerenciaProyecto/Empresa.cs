using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaProyecto
{
    public partial class Empresa
    {

        public Empresa(string nombre)
        {
            Nombre = nombre;
        }

       

       

        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"[Empresa .Nombre : {Nombre}]";
        }
    }

    
}
