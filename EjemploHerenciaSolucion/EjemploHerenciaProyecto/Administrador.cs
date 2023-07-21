using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerenciaProyecto
{
    public class Administrador : Empleado
    {
        

        public bool TieneParking { get; set; }


        public Administrador()
        {
            
        }

        public Administrador(string Nombre, bool tieneParking) : base(Nombre)
        {
            TieneParking = tieneParking;
        }

        public bool TienePlazaParking()
        {
            if (TieneParking)
            {
                Console.WriteLine("El administrador tiene plaza parking.");
            }
            else
            {
                Console.WriteLine("El administrador no dispone de plaza parking");
            }
            return TieneParking;
        }


        public string PlazaParking()
        {
            //Todo :Conectar a BBDD
            throw new ErrorBaseDatosExcepcion("Error al conectar a BBDD", DateTime.Now);
            return TieneParking ? "Plaza A" : "No tiene plaza";
        }
            


        public override void CalculoVacaciones()
        {
            diasVacaciones += 9;
        }

        public override string ToString()
        {
            
            
                return $"[Administrador .Nombre: {Nombre} y tiene plaza parking: {TieneParking} ";
            
            
            
                
            }
        }
    }
