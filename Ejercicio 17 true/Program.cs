using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_17_true;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";  /// esta incompleto, faltan detalles
            string dibujo;
            short gasto;
            string continuar;
            int aux;


           // short tintaBlue = 100;
           // short tintaRed = 50;

            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRed = new Boligrafo(50, ConsoleColor.Red);
            do
            {
                
                Console.WriteLine("Elija boligrafo:\n 1 para azul\n 2 para rojo");
                aux = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese gasto de tinta");
                gasto = short.Parse(Console.ReadLine());
                if (aux == 1)
                {
                    Console.ForegroundColor = boligrafoAzul.getColor();
                    if (!boligrafoAzul.Pintar(gasto, out dibujo))
                    {
                        Console.WriteLine("\nNo more tinta");
                    }
                }
                else if (aux == 2)
                {
                    Console.ForegroundColor = boligrafoRed.getColor();
                    if (!boligrafoRed.Pintar(gasto, out dibujo))
                    {
                        Console.WriteLine("\nNo more tinta");
                    }
                }
            
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nDesea continuar? s/n");
                continuar = Console.ReadLine();

            } while (continuar!="n");
        }
    }
}
