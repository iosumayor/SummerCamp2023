using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjemploFuncAction
{
    public class Ejemplo
    {

        private readonly Action<string> _action;
        public Action<int> AccionProperty { get; set; }
        internal void EjemploFunc()
        {


            
            // Expresión Lambda mediante Func<>

            Func<string> holaMundoExpresion =

             //parametros
             ()
             //operador lambda 
             =>
             //Delegado / Método anónimo / Expresión 
             " Hola Mundo !!!!";
            Console.WriteLine(holaMundoExpresion);  
            Console.WriteLine(holaMundoExpresion());

            //Expresion Lambda mediante Bloque Func<>
            Func<string> holaMundoBloque =

             //parametros
             ()
             //operador lambda 
             =>
             //Delegado / Método anónimo 
             {
                 var cadena = " Hola Mundo!!!!!";
                 return cadena;
             };
            Console.WriteLine(holaMundoBloque());

            //Crear una expresion lambda que sume dos numeros
            //Console.WriteLine(sumar(10, 20));
            Func<int, int, int> sumar = 
             //parametros
             (x,y)
             //operador lambda 
             =>(int)(x+y);
             //Delegado / Método anónimo
             {
                Console.WriteLine(sumar(10, 20));
             }


            Func<int,int ,int> SumarPedro =

            (a,b)

            =>

            { return a+b; };
        }


        internal void EjemploAction()
        {
            // Llamar a TestAction pasandole metodo como parametro
            TestAction(AccionMetodo, 1);

            //Llamar a TestAction escribiendo la expresion lambda
            //como parametro entre los 2 parametros

            TestAction((x) => Console.WriteLine("En el parametro accion " + x),1);


            //1-Crear una variable que almacene la accion
            //2-Llamar a TestAction pasandole la variable y el valor 1

            Action<int> accion = (y) =>
            {
                Console.WriteLine("En el Parametro Accion " + y);
            };

            TestAction(accion, 1);


            List<Action<int>> listaAcciones = new List<Action<int>>();

            listaAcciones.Add(accion);
            listaAcciones.Add(AccionMetodo);

            foreach (var elementoAccion in listaAcciones)
            {

            }

        }


        //Metodo que recibe un Action<int> y un int
        //Dentro tiene que llamar al action
        public void TestAction(Action<int> action, int numero)
         {
            action(numero);
         }

        public void AccionMetodo(int numero)
        {
            Console.WriteLine($"En el metodo Accion {numero}");
        }


        
    }
}
