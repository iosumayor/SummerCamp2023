using Entidades;

namespace ejercicio
{
    //Calcular el salario empleados
    internal class Program
    {
        static void Main(string[] args)
        {
            var Jose = new Empleado();
            Jose.Nombre = "Jose";
            Jose.FechaAlta = new DateTime(2021, 01, 10);
            Jose.Salario = 20000;
            Jose.Alta = true;
            Jose.FijarNivel(Empleado.Nivel.excelente);

            // Crear y asignar valores a propiedades directamente
            var Maria = new Empleado()
            {
                Nombre = "Maria",
                FechaAlta = new DateTime(2022, 03, 01),
                Salario = 20000,
                Alta = true
            };
            Maria.FijarNivel(Empleado.Nivel.excelente);

            var Juan = new Empleado("Juan", 20000, new DateTime(2023, 01, 15),true);
            Juan.FijarNivel(Empleado.Nivel.excelente);

            var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            numeros.Add(9);

            var lista = new List<Empleado>();
            lista.Add(Maria);
            lista.Add(Juan);
            lista.Add(Jose); 

            foreach (var empleado in lista) {

                empleado.CalcularAumentoSlario();

            }
        }
    }
}