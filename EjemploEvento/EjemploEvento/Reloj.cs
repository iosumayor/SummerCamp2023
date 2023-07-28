using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEvento
{
    internal class Reloj
    {


        //Delegado

        public delegate void CambioSegundoDelegado(object reloj, InformacionTiempoEventArgs informacionTiempo);//Se manda un object y no el propio tipo(es decir reloj)




        //Evento

        public event CambioSegundoDelegado CambioSegundoEvento;


        private int segundo;

        public void IniciarReloj()
        {
            DateTime fechaHoraActual;
            for (; ; )
            {

                Thread.Sleep(100);
                fechaHoraActual = DateTime.Now;

                if (fechaHoraActual.Second != segundo)
                {

                    //Console.WriteLine(segundo);
                    // Guardar info tiempo
                    var informacionTiempo = new InformacionTiempoEventArgs(fechaHoraActual.Hour,
                                                                            fechaHoraActual.Minute,
                                                                            fechaHoraActual.Second);


                    //Lanzar el evento

                    if (CambioSegundoEvento != null)
                    {

                        CambioSegundoEvento(this, informacionTiempo);
                    }
                    segundo = fechaHoraActual.Second;

                }
            }
        }
    }
}

