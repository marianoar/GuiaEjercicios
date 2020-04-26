using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº3";
            string ingreso;
            bool isNumber;
            int number;
            int contador=0;
            int aux;

            Console.WriteLine("ingrese un numero: ");
            ingreso = Console.ReadLine();
            isNumber = int.TryParse(ingreso, out number);
            while ((!isNumber) || (number < 0))
            {
                Console.WriteLine("Error. ingrese nuevamente numero: ");
                ingreso = Console.ReadLine();
                isNumber = int.TryParse(ingreso, out number);
            }

            Console.WriteLine("El numero ingresado fue {0}", number);
            do
            {
                for (int i = 1; i <= number; i++)
                {
                    aux = number % i;
                    //Console.WriteLine("resto: {0}", aux);
                    if (aux == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    Console.WriteLine("el numero {0} es primo", number);
                }
                else
                {
                    Console.WriteLine("el numero {0} no es primo", number);
                }
                Console.ReadKey();
                number--;
                contador = 0;
            } while (number > 1);
            
        }
    }
}
