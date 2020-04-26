using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº2";
            string ingreso;
            bool isNumber;
            double number;
            double cuadrado;
            double cubo;

            Console.WriteLine("ingrese un numero: ");
            ingreso = Console.ReadLine();
            isNumber = double.TryParse(ingreso, out number);
            while ((!isNumber) || (number < 0))
            {
                Console.WriteLine("Error. ingrese nuevamente numero: ");
                ingreso = Console.ReadLine();
                isNumber = double.TryParse(ingreso, out number);
            }
            cuadrado = Math.Pow(number, 2);
            cubo = Math.Pow(number, 3);

            Console.WriteLine("El numero ingresado fue {0}, su cuadrado es {1} y su cubo es {2}", number, cuadrado, cubo);
            Console.ReadKey();
        }
    }
}
