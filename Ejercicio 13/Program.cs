using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): 
             * string DecimalBinario(int). Convierte un número de entero a binario. 
             * int BinarioDecimal(string). Convierte un número binario a entero.*/

            Console.Title = "Ejercicio Nº13";

            string ingreso;
            string newBinario;
            int number;
            bool isNumber;
            
            Console.WriteLine("ingrese un numero entero positivo: ");
            ingreso = Console.ReadLine();
            isNumber = int.TryParse(ingreso, out number);
            while ((!isNumber) || (number < 1))
            {
                Console.WriteLine("Error. ingrese nuevamente");
                ingreso = Console.ReadLine();
                isNumber = int.TryParse(ingreso, out number);
            }

            newBinario = Conversor.DecimalBinario(number);
            Console.WriteLine("El entero ingresado fue {0} y su equivalente en binario es :{1}",number, newBinario);
            Console.ReadKey();



            string binario;
            bool flag = true;
            int entero=9;
            Console.WriteLine("Ingrese numero en formato binario");
            binario = Console.ReadLine();
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    Console.WriteLine("Parece que hay algo mal");
                    Console.ReadKey();
                    flag = false;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (flag)
            {
                entero = Conversor.BinarioADecimal(binario);
                Console.WriteLine("El binario ingresado fue {0} y su entero decimal equivalente es {1}", binario, entero);
                Console.ReadKey();
            }
        }
    }
}
