using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {

            Libro libro = new Libro();

            libro[2] = "pagina Z";
            Console.WriteLine(libro[0]);
            Console.WriteLine(libro[1]);
            Console.WriteLine(libro[2]);
            Console.WriteLine(libro[3]);
            
            libro[5] = "pagina E";

            Console.ReadKey();



        }
    }
}
