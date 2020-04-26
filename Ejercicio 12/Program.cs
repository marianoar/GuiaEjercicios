using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*12. Realizar un programa que sume números enteros hasta que el usuario lo determine, 
             * por medio de un mensaje "¿Continuar? (S/N)". 
             * En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, validará el ingreso de opciones. 
             * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier.*/
            Console.Title = "Ejercicio Nº12";

            string ingreso;
            int number = 0;
            bool isNumber;
            int suma = 0;
            char respuesta;
            string aux;
            
            do
            {
                Console.WriteLine("Ingrese un numeros enteros");
                ingreso = Console.ReadLine();
                isNumber = int.TryParse(ingreso, out number);
                while ((!isNumber))
                {
                    Console.WriteLine("Error. ingrese eun numero: ", ingreso);
                    ingreso = Console.ReadLine();
                    isNumber = int.TryParse(ingreso, out number);
                }
                suma = suma + number;
                Console.WriteLine("Desea continuar sumando? S/N");
                
                aux = Console.ReadLine();
                respuesta = Convert.ToChar(aux);
            } while (ValidarRespuesta.ValidaS_N(respuesta));
            Console.WriteLine("La suma total de los numeros ingresados es {0}", suma);
            Console.ReadKey();
        }
    }
}
