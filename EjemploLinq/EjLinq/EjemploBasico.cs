using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjLinq
{
    public class EjemploBasico
    {

        public EjemploBasico() { 
        
        }

        public void Ejecutar()
        {
            string[] niveles = { "Basico", "Intermedio", "Avanzado" };
            int nc = niveles.Count();

            // Selecciona todos los niveles cuya longitud en caracteres
            //sea mayor que 6
            //ordenado por nivel

            var listaConsultaForEach = new List<string>();

            foreach (string nivel in niveles)
            {

                if(nivel.Length > 6)
                {
                    listaConsultaForEach.Add(nivel);
                }

            }

            //Sintaxis SQL
            //Select nivel from niveles where  nivel.length > 6 order by niveles
            //1-Preparacion
            var consultaLinq = from nivel in niveles where nivel.Length > 6 orderby nivel select nivel;

            //2-Obtener Resultados
            List<string> listaResultados = consultaLinq.ToList();//Convertir a una lista la info que nos llega para poder tratarla

            //Sintaxis de Metodos
            //1-Preparacion
            Func<string, bool> predicado = nivel => nivel.Length > 6;

            //var consultaLinqMetodos = niveles.Where(predicado);
            var consultaLinqMetodos = niveles.Where(nivel => nivel.Length > 6).OrderBy( nivel => nivel).Select(nivel => nivel) ;
            //2-Resultados


            List<string> listaResultadosLinqMetodos = consultaLinqMetodos.ToList();

        }

    }
}
