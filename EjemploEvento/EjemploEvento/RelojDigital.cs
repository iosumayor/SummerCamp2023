using System.Timers;

namespace EjemploEvento
{
    internal class RelojDigital
    {

        
        public RelojDigital()
        {


        }

        internal void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;// += te genera el evento de abajo
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs informacionTiempo)
        {

            
            Console.WriteLine($"Hora Actual: {informacionTiempo.Hora.ToString()} " +
                               $"{informacionTiempo.Minuto.ToString()} " +
                               $"{informacionTiempo.Segundo.ToString()}");
        }
    }
}