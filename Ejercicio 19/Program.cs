using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {

            Sumador sA = new Sumador(-1);
            Sumador sB = new Sumador();
            
            Console.WriteLine("sumador A:"+sA.Sumar(4, 8));
            Console.WriteLine("sumador A:" + sA.Sumar("4", "4"));
            Console.WriteLine("sumador A -> cantidad de sumas:" + sA.CantidadSumas);
            Console.WriteLine("sumador B: " + sB.Sumar(4, 16));
            Console.WriteLine(sA + sB);
            Console.WriteLine(sA | sB);

            Console.ReadKey();
        }
    }
}
