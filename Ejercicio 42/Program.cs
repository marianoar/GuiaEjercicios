using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            try
            {
                MiClase miclase = new MiClase(a);
            }
            catch
            {
                Console.WriteLine("- - - - - Catch primer Excepcion");
                try
                {
                    MiClase miclaseDos = new MiClase(a);
                }
                catch
                {
                    
                    throw new UnaExcepcion();
                }
            }
            finally // por aca pasa siempre
            {

            }
            Console.ReadKey();
           // MiClase.Lanzar();
        }
    }
}
