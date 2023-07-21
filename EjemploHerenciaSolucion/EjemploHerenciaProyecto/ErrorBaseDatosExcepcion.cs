using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaProyecto
{
    public class ErrorBaseDatosExcepcion : Exception
    {
        public string mensaje{ get; set; }
        public DateTime fechaHoraExcepcion { get; set; }
        

        public ErrorBaseDatosExcepcion(string mensaje, DateTime fechaHoraExcepcion):base(mensaje)
        {
            this.mensaje = mensaje;
            this.fechaHoraExcepcion = fechaHoraExcepcion;
        }
    }
}
