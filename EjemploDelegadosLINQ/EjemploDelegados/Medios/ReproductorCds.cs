using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class ReproductorCds
    {

        public bool ProbarCD()
        {
            Console.WriteLine("Por favor, ponga el cd en el reproductor");
            Console.WriteLine("Pulsa el boton de reproduccion");
            Console.WriteLine("Indique a continuacion si ha escuchado algo");
            var result = Console.ReadLine();

            ///Equivale a if (result=="S")/else

            return result == "S";
        }


        public string InfoPelicula(string pelicula)
        {
            bool existeBaseDeDatos = false;

            //Buscar en BBDD codigo de barras
            //Devolver resultado

            try
            {
                if (existeBaseDeDatos = true)
                {
                    Console.WriteLine("Hay info de la pelicula " + pelicula);
                }
                else
                {
                    Console.WriteLine("No hay info de la pelicua");
                }
            }
            catch (Exception ex)
            {
                return "Error " + ex.Message;
            }

            return pelicula;
        }
    }
}
