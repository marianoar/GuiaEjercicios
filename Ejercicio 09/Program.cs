﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº9";

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

            for (int i = 0; i <= number+1; i++)
            {
                for (int j = 1; j <= i-1; j++)
                {
                        Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
