using System.Runtime.CompilerServices;
using System.Timers;

namespace EjemploEvento
{
    internal class Registro
    {

        


        public Registro()
        {
        }

        internal void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs informacionTiempo)
        {

            int segundos = informacionTiempo.Segundo;
            ///TimeSpan tiempo = TimeSpan.FromSeconds(10);
            ///Console.WriteLine(informacionTiempo.Segundo.ToString.Format(tiempo));
            

            if (segundos % 10 == 0)
            {


                Console.WriteLine($"Hora Actual: {informacionTiempo.Hora.ToString()} " +
                                   $"{informacionTiempo.Minuto.ToString()} " +
                                   $"{informacionTiempo.Segundo.ToString()}" + " La fecha actual es " +  DateTime.Now.Year +" " + DateTime.Now.Month + " " + DateTime.Now.Day);
            }


            
        }


        





    }
}