using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº1";
            string ingreso;
            int number;
            int min=0;
            int max=0;
            int prom=0;
            int suma=0;
            bool flag=false;
            bool isNumber;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("ingrese el {0}er numero: ", i);
                ingreso = Console.ReadLine();
                isNumber = int.TryParse(ingreso, out number);
                while (!isNumber)
                {
                    Console.WriteLine("Error. ingrese el {0}er numero: ",i);
                    ingreso = Console.ReadLine();
                    isNumber = int.TryParse(ingreso, out number);
                }

                if (!flag)
                {
                    min = number;
                    max = number;
                    flag = true;
                }
                else
                {
                    if (number < min)
                    {
                        min = number;
                    }
                    if (number > max)
                    {
                        max = number;

                    }
                }
            suma = suma + number;
            }
            prom = suma / 5;
            Console.WriteLine("el menor numero fue {0} y el mayor fue {1}", min, max);
            Console.WriteLine("el valor acumulado fue {0} y el promedio fue {1}" , suma, prom) ;
            Console.ReadKey();
         }
    }
}

