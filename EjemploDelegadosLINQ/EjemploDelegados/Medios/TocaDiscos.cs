using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class Tocadiscos
    {

        

        public bool ProbarVinilo()
        {
            Console.WriteLine("Por favor, ponga el disco en el tocadiscos");
            Console.WriteLine("Indique a continuación si ha escuchado algo S/N");
            var result = Console.ReadLine();

            // Equivale a if (result=="S")/else
            return result == "S";
        }

        // string           string
        public string ObtenerCancionesDisco(string codigoBarras)
        {

            bool existeBaseDeDatos = false;

            //Buscar en BBDD codigo de barras
            //Devolver resultado

            try
            {
                if(existeBaseDeDatos = true)
                {
                    Console.WriteLine("El disco existe y su codigo de barras es " + codigoBarras);
                }
                else {
                    Console.WriteLine("El disco no existe");
                }
            }catch(Exception ex)
            {
                return "Error " + ex.Message;
            }
            return "Lista de cacniones estan en la contraportada";
        }


    }
}
