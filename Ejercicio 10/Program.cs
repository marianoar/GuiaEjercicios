using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO INCOMPLETO -falta centrar

            Console.Title = "Ejercicio Nº10";

            string ingreso;
            int number;
            bool isNumber;

            Console.WriteLine("ingrese altura: ");
            ingreso = Console.ReadLine();
            isNumber = int.TryParse(ingreso, out number);
            while ((!isNumber) || (number < 1))
            {
                Console.WriteLine("Error. ingrese nuevamente");
                ingreso = Console.ReadLine();
                isNumber = int.TryParse(ingreso, out number);
            }
           
            for (int i = 0; i <= number + 1; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
    
}
