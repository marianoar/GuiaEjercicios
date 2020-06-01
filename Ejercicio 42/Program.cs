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

         //   Pruebas.MetodoExc();

            int a = 0;
            try
            {
                MiClase miclase = new MiClase(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
              try
                {
                    MiClase miclaseDos = new MiClase(a);
                }
                catch
                {
                   // throw new MiExcepcion(e.InnerException);
                }
            }
            finally // por aca pasa siempre
            {
                Console.WriteLine("\nbloque finaly");
            }
            Console.ReadKey();
           // MiClase.Lanzar();
        }
    }
}
