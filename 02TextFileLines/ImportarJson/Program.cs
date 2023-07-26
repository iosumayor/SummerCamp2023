using DataProcessor;
using Newtonsoft.Json;

namespace ImportarJson
{
    public class Program
    {
        static void Main(string[] args)
        {
            string json = @"{
            'Name': 'Bad Boys',
            'ReleaseDate': '1995-4-7T00:00:00',
            'Genres': [
            'Action',
            'Comedy'
            ]
            }";

            Movie m = JsonConvert.DeserializeObject<Movie>(json);

            string name = m.Name;
            string releaseDate = m.ReleaseDate;
            string  genres = string.Join(",", m.Genres);// Convert the array to a formatted string

            Console.WriteLine(name  +" " +releaseDate + " "+ genres);
            // Bad Boys

            try
            {
                string json1 = File.ReadAllText("monedas.json");
                List<Moneda> monedas = JsonConvert.DeserializeObject<List<Moneda>>(json1);///para la lista siempre <>

                foreach (var moneda in monedas)///usar foreach para recorrer monedas
                {

                    ///string nombre = moneda.nombre;

                    ///string codigo = moneda.codigo;

                    ///float valorEnDolares = moneda.valorEnDolares;

                    ///Console.WriteLine(nombre + " " + codigo + " " + valorEnDolares);

                    Console.WriteLine($"{moneda.nombre} ({moneda.codigo}) - Valor en Dólares: {moneda.valorEnDolares}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer el json" + e.Message);
            }
        }



    }
}