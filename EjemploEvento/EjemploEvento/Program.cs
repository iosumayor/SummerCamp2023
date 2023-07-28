namespace EjemploEvento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Crear instancia del reloj (Publicador)


            var reloj = new Reloj();
            //2-Crear un reloj digital (Suscriptor)

            var relojDigital = new RelojDigital();
            //relojDigital.Suscribir(reloj);

            //Ejercicio
            //Crear un log o registro que guarde cada 10 s
            // la fecha y hora
            var log = new Registro();
            log.Suscribir(reloj);

            //3-Poner en marcha el reloj


            reloj.IniciarReloj();
        }
    }
}