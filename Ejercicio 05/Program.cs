using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Title = "Ejercicio 05";
            Console.WriteLine("Ejercicio 5 -- Calculo centro numerico");
            string input;
            int aumento = 1,  numero, i, j,
                sumaAtras,
                sumaAdelante;
            bool isNumber;

            Console.Write("Ingrese un numero entero positivo: ");
            input = Console.ReadLine();
            isNumber = int.TryParse(input, out numero );
            while (!isNumber) {
                Console.Write("Error. Ingrese un numero : ");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out numero);
            }
            
            while (aumento < numero)
            {

                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                
                for (i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                }
             
                for (j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante = sumaAdelante + j;
                }

                
                if (sumaAtras == sumaAdelante)
                    Console.WriteLine("Los centro numerico son: {0}", aumento);
            }
            Console.ReadLine();
        }
    }
}
