using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args) //habria q revisarlo de nuevo por q cambie visibilidad 7/6
        {

         //   Pruebas.MetodoExc();
         
            int a = 0;

            try
            {
                OtraClase miClase = new OtraClase();
            }
            catch (Exception e)
            {
                
                Console.WriteLine($"\nTercera -{e}");
            }
        
            
                /* Console.WriteLine(e.Message);
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
            
            // MiClase.Lanzar();*/
                Console.ReadKey();
            
        }
    }
}
