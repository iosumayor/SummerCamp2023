using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2Parte6Proyecto
{
    public class MonedasConverter

        ///voy creando conversores para cada uno y que me devulevan la moneda que quiero
    {
        public static double EurosToDolares(string monEuros)
        {
            double euros = Double.Parse(monEuros);
            double dolares = euros * 1.12;
            return dolares;
        }

        public static double DolaresToEuros(string monDolares)
        {
            double dolares = Double.Parse(monDolares);
            double euros = dolares * 0.89;
            return euros;
        }


        public static double EurosToLibras(string monEuros)
        {
            double euros = Double.Parse(monEuros);
            double libras = euros * 0.87;
            return libras;
        }

        public static double LibrasToEuros(string monLibras)
        {
            double libras = Double.Parse(monLibras);
            double euros = libras * 1.15;
            return euros;
        }

        public static double DolaresToLibras(string monDolares)
        {
            double dolares = Double.Parse(monDolares);
            double libras = dolares * 0.77;
            return libras;
        }

        public static double LibrasToDolares(string monLibras)
        {

            double libras = Double.Parse (monLibras);
            double Dolares = libras * 1.30;
            return Dolares;
        }



    }
}
