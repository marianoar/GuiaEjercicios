using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 27"; /// FALTA ORDENAR LAS COLAS

            List<int> lista = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> cola = new Queue<int>();

            Random random = new Random();
            int vector;
            int aux;
            int aux2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" - - - - - List< > - - - - - ");
            Console.WriteLine("a. Lista, tal como es creada");

            while (lista.Count < 20)
            {
                lista.Add(random.Next(-1000, 1000));

            }
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" - - - - - List< > - - - - - "); 
            Console.WriteLine("Mostrar los positivos ordenados en forma decreciente");
            lista.Sort();
            lista.Reverse();
            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i]>0)
                Console.WriteLine(lista[i]);
            }
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine(" - - - - - List< > - - - - - ");
            Console.WriteLine("Mostrar los negativos ordenados en forma creciente");
            lista.Reverse();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] < 0)
                    Console.WriteLine(lista[i]);
            }
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Colas y Pilas no pueden ordenarse por si mismas");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" - - - - - Stack < > - - - - - ");
            Console.WriteLine("a. Stack, tal como es creada");
            while (stack.Count < 20)
            {
                stack.Push(random.Next(-1000, 1000));

            }
            foreach (var item in stack)
            {
                Console.WriteLine("{0}", item);
            }

            
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" - - - - - Stack< > - - - - - ");
            Console.WriteLine("Mostrar los positivos ordenados en forma decreciente");
            metodo.Sort(stack);
            /*
            Stack<int> auxStack = new Stack<int>();
            int auxiliar;
            //  aux[0] = vector[i];
            // vector[i] = vector[j];
            //  vector[j] = aux[0];
            for (int i = 0; i < stack.Count; i++)
            {
                for (int h = 0; h < stack.Count; h++)
                {
                    if (stack.ElementAt(i) < stack.ElementAt(h))
                    {
                        stack.
                        auxiliar = stack.ElementAt(i);

                        stack.Push(stack.ElementAt(h));
                        stack.Push(auxiliar);
                    }
                }
            }
           */
            foreach (var item in stack)
            {
               if(item>0)
                    Console.WriteLine("{0}", item);
              
            }


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" - - - - - Stack< > - - - - - ");
            Console.WriteLine("Mostrar los negativos ordenados en forma creciente");

            foreach (var item in stack)
            {
                if (item <  0)
                    Console.WriteLine("{0}", item);

            }


            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" - - - - - Queue < > - - - - - ");
            Console.WriteLine("a. Queue, tal como es creada");
            while (cola.Count < 20)
            {
                cola.Enqueue(random.Next(-1000, 1000));

            }
            foreach (var item in cola)
            {
                Console.WriteLine("{0}", item);
            }


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" - - - - - Queue< > - - - - - ");
            Console.WriteLine("Mostrar los positivos ordenados en forma decreciente");
            metodo.SortCola(cola);

            foreach (var item in cola)
            {
                if (item > 0)
                    Console.WriteLine("{0}", item);

            }


            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" - - - - - Queue< > - - - - - ");
            Console.WriteLine("Mostrar los negativos ordenados en forma creciente");

            foreach (var item in cola)
            {
                if (item < 0)
                    Console.WriteLine("{0}", item);

            }


            Console.ReadKey();

        }
    }
}
