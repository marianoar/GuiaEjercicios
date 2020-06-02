using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Pruebas
    {
        public static void MetodoExc( )
        {
            try
            {
                Console.Write("ingrese numero: ");
                int a = int.Parse(Console.ReadLine());

            }catch (FormatException)
            {
                Console.WriteLine("Error");


            }
        }

    }
}
