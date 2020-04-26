using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_true
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            short tintaBlue = 100;
            short tintaRed = 50;

            Boligrafo boligrafo1 = new Boligrafo(tintaBlue, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(tintaRed, ConsoleColor.Red);
        }
    }
}
