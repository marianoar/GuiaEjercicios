using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 26";

            Random random = new Random();
            int[] vector = new int[20];
            int[] aux = new int[1];
            int[] aux2;
            Console.WriteLine("a. Mostrar el vector tal como fue ingresado");
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.Next(-1000, 1000);
                if (vector[i] == 0)
                {
                    continue;
                }
                
                Console.WriteLine(vector[i]);
            }

            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j= 0; j < vector.Length; j++)
                {
                    if (vector[i] < vector[j])
                    {
                        aux[0] = vector[i]; 
                        vector[i] = vector[j];
                        vector[j] = aux[0];

                    }
                }
            }
            Console.WriteLine("Mostrar los positivos ordenados en forma decreciente");
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > 0)
                {
                    Console.WriteLine(vector[i]);
                }
            }
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < 0)
                {
                    Console.WriteLine(vector[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
