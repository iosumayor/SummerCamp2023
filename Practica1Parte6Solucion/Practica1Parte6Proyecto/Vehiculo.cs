

namespace Practica1Parte6Proyecto
{
    public class Vehiculo
    {
        public int FechaCompra { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; } 
        public string Color { get; set; }


        public Vehiculo(int FechaCompra, string Modelo, string Marca,string Color)
        {
            this.FechaCompra = FechaCompra;
            this.Modelo = Modelo;
            this.Marca = Marca;
            this.Color = Color;
        }



        public Vehiculo() { 
        
        }
    }
}
