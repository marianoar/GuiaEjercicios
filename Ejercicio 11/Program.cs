using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*11. Realizar una clase llamada Validacion que posea un método estático llamado Validar: 
            bool Validar(int valor, int min, int max):
            a. valor: dato a validar
            b. min y max: rango en el cual deberá estar la variable valor.
            Pedir al usuario que ingrese 10 números enteros. 
            Validar con el método desarrollado anteriormente que esten dentro del rango -100 y 100. 
            Terminado el ingreso mostrar el valor mínimo, el valor máximo*/
            Console.Title = "Ejercicio Nº11";

            string ingreso;
            int number=0;
            int min = 0;
            int max = 0;
            int limitInferior = -100;
            int limitSuperior = 100;
            bool flag = false;
            bool isNumber;
            int suma=0, prom;

            Console.WriteLine("Deberá ingresar diez numeros enteros");
            for (int i = 1; i < 11; i++)
            {
               
                Console.WriteLine("ingrese el {0}er numero: ", i);

                ingreso = Console.ReadLine();
                isNumber = int.TryParse(ingreso, out number);
                while ((!isNumber) || (!Validacion.Validar(number, limitInferior, limitSuperior)))
                {
                        Console.WriteLine("Error. ingrese el {0}er numero: ", i);
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
            
        
            prom = suma / 10;
                

                
                
            
            
            Console.WriteLine("el menor numero fue {0} y el mayor fue {1}", min, max);
            Console.WriteLine("el promedio fue {0}", prom);

            Console.ReadKey();

        }
    }
}
