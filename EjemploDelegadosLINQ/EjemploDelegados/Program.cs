using EjemploDelegados.Medios;
using static EjemploDelegados.InventarioMedios;

namespace EjemploDelegados
{
    internal class Program
    {

        //Hay que crear una aplicacion para el archivo de medios de una bibloteca publica de modo que:
        //A-Segun el tipo de medio indique al usuario los pasos a dar para reproducir ese medio y verificar si esta en buen estado para archivarlo o bien desecharlo si esta en mal estado
        //B-Crear una aplicacion que permita indicar los pasos a dar independientemente del medio  <summary>
        //C-Mostrar el contenido del medio segun el tipo de medio
        //Pasar codigo de barras o idenficador para localizar el medio en la BBDD
        // Cds - Mostrar lista de canciones
        // Vinilo - Mostrar lista de canciones en la contraportada
        // VHS - Mostrar informacion de la película
        
        static void Main(string[] args)
        {
            

            //1-Crear instancia
            //Crear la instancia del inventario de medios
            var inventarioMedios = new InventarioMedios();

            //Crear instancia reproductor de cassette
            var reproductorCassette = new ReproductorCassette();

            //Crear instancia TocaDiscos
            var tocaDiscos = new Tocadiscos();

            //Crear instancia reproductor Vhs
            var videoVhs = new VideoVhs();


            var ReproductorCds = new ReproductorCds();


            //2-Crear instancia de delegados

            //Crear instancia del delegado para probar discos de vinilo
            ProbarMediosDelegado probarDiscoDelegado = new ProbarMediosDelegado(tocaDiscos.ProbarVinilo);


            //Crear instancia del delegado para probar cinta vhs
            ProbarMediosDelegado probarCintasVhsDelegado = new ProbarMediosDelegado(videoVhs.ProbarVideosVhs);


            InfoMedioDelegado infoCanciones = new InfoMedioDelegado(tocaDiscos.ObtenerCancionesDisco);

            InfoMedioDelegado infoMedioDelegado = new InfoMedioDelegado(ReproductorCds.InfoPelicula);

            //3-Utilizar delegados

            //Probar un vinilo
            //inventarioMedios.ResultadoProbarMedios(probarDiscoDelegado);

            //Probar una cinta VHS
            //inventarioMedios.ResultadoProbarMedios(probarCintasVhsDelegado);


            inventarioMedios.ResultadoInfoMedios(infoCanciones, "123321321312");
            inventarioMedios.ResultadoInfoMedios(infoMedioDelegado, "Rambo");

            


        }
    }
    


    
            
        
    }
