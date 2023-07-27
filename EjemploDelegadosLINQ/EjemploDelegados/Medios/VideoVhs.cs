using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados.Medios
{
    public class VideoVhs
    {

        public bool ProbarVideosVhs()
        {
            Console.WriteLine("Por favor,ponga la cinta en el reproductor");
            Console.WriteLine("Indique a continuacion si ha visto el video");
            var result = Console.ReadLine();

            ///Equivale a if (result=="S)/else
            return result == "S";
        }
    }
}
