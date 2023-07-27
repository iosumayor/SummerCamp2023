using EjemploDelegados.Medios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EjemploDelegados
{
    public class InventarioMedios
    {


        // 1            2
        // bool         ()
        //public bool ProbarCd  ()
        //public bool ProbarVinilo  ()
        //public bool ProbarVideosVhs   ()


        //Declarar el delegado probar medios
        //1             2


        public delegate bool ProbarMediosDelegado();


        public delegate string InfoMedioDelegado(string id);
        public void ResultadoProbarMedios(ProbarMediosDelegado medio)
        {
            ///1-Recibir el medio a probar
            ///2-Probar el medio
            ///3-Si le medio se ha podido reproducir indicar como archivarlo
            ///

            var resultadoPrueba = medio();


            if (resultadoPrueba)
            {
                Console.WriteLine("El medio funciona, " + "hay que agregarlo al inventario");
            }
            else
            {
                Console.WriteLine("El medio no funciona, destruirlo");
            }



            /*var tipo = medio.GetType().FullName;
            if(tipo == "Tocadiscos")
            {
                var obj = (Tocadiscos)medio;
                if (obj.ProbarVinilo())
                {
                    Console.WriteLine("instrucciones para almacenar vinilo");
                }
            }*/
        }


        public void ResultadoInfoMedios(InfoMedioDelegado
            info, string id)
        {
            var resultadoInfo = info(id);

            if(string.IsNullOrEmpty(resultadoInfo))
            {
                Console.WriteLine("La info no existe hay que agregarla");
            }
            else
            {
                Console.WriteLine("Existe la info");
            }
        }

        
    }
}
