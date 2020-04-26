using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº4";
            int b; 
            int num=10000; 
            int j;
            string divisores = "";
           // byte contador = 0;

        
           
                for (int i = 1; i <= num; i++)
                {
                    b = 0;

                    for (j = 1; j <= (i / 2); j++)
                    {
                        if (i % j == 0)
                        {
                            b += j;
                            divisores += " " + j + " ";
                        }
                    }
                    if (b == i)
                        Console.WriteLine("El numero " + i + " es perfecto y su divisores son: " + divisores);
                    divisores = "";
                }
                Console.ReadKey();
            
            /*
            int numero = 1;
            int aux;
            int contador = 0;
            int acumulador = 0;

            do
            {

                for (int i = 1; i < numero; i++)
                {
                    aux = numero % i;
                    //Console.WriteLine("resto: {0}", aux);
                    if (aux == 0)
                    {
                        acumulador = i + acumulador;
                    }
                    if (acumulador == numero)
                    {
                        continue;
                    }
                    Console.WriteLine("el numero perfecto es : {0}", numero);
                    Console.ReadKey();

                }
                
                acumulador = 0;
                numero++;
               contador++;
            } while (contador < 5);
            */
        }
         
    }
}
