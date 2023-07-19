namespace Practica2Parte6Proyecto
{
    public class Program
    {
        static void Main(string[] args)
        {
            string selection = String.Empty;///dejo una seleccion vacia para poder seleccionar la opcion

            while (selection != "c" && selection !="C") {

                Console.Write("Introduce E) para elegir Euros , Introduce D) para elegir Dolares ,Introduce L) para elegir Libras o Introduce C) para cerrar:  ");

                selection = Console.ReadLine();

                double euros, dolares, libras = 0;///tener las variables iniciadas

                
                


                switch (selection)
                {
                    case "E":
                    case "e":
                        Console.Write("Introduce D) para cambiar a Dolares, Introduce L) para cambiar a Libras: ");

                        string eurosSelection = String.Empty;
                        eurosSelection = Console.ReadLine();


                        switch (eurosSelection)
                        {
                            case "D":
                            case "d":
                                Console.Write("Introduce la cantidad de Euros: ");
                                dolares = MonedasConverter.EurosToDolares(Console.ReadLine());
                                Console.WriteLine("Tienes : " + dolares +" dolares");
                                break;

                            case "L":
                            case "l":
                                Console.Write("Introduce la cantidad de Euros: ");
                                libras = MonedasConverter.EurosToLibras(Console.ReadLine());
                                Console.WriteLine($"Tienes : {libras:f2} libras");
                                break;

                            default:
                                Console.WriteLine("Intente otra vez ");
                                break;
                                

                               

                        }
                     break;

                    case "D":
                    case "d":

                        Console.Write("Introduce E) para cambiar a Euros, Introduce L) para cambiar a Libras: ");

                        string dolarSelection = String.Empty;
                        dolarSelection = Console.ReadLine();

                        switch (dolarSelection)
                        {
                            case "E":
                            case "e":
                                Console.Write("Introduce la cantidad de Dolares: ");
                                euros = MonedasConverter.DolaresToEuros(Console.ReadLine());
                                Console.WriteLine($"Tienes : {euros:f2} euros");
                                break;

                            case "L":
                            case "l":
                                Console.Write("Introduce la cantidad de Dolares: ");
                                libras = MonedasConverter.DolaresToLibras(Console.ReadLine());
                                Console.WriteLine($"Tienes : {libras:f2} libras");
                                break;

                            default:
                                Console.WriteLine("Intente otra vez ");
                                break;
                        }
                        break;

                    case "L":
                    case "l":

                        Console.Write("Introduce E) para cambiar a Euros , Introduce D) para cambiar a Dolares: ");

                        string libraSelection = String.Empty;
                        libraSelection = Console.ReadLine();

                        switch (libraSelection)
                        {

                            case "E": 
                            case "e":
                                Console.Write("Introduce la cantidad de Euros: ");
                                euros = MonedasConverter.LibrasToEuros(Console.ReadLine());
                                Console.WriteLine($"Tienes : {euros:f2} euros");
                                break;

                            case "D":
                            case "d":
                                Console.Write("Introduce la cantidad de Dolares: ");
                                dolares = MonedasConverter.LibrasToDolares(Console.ReadLine());
                                Console.WriteLine($"Tienes : {dolares:f2} dolares");
                                break;

                            default:
                                Console.WriteLine("Intente otra vez ");
                                break;
                                ;                        }

                    break;

                    default:
                        Console.WriteLine("Intente otra vez.");
                    break;
                }

            
            }
        }
    }
}