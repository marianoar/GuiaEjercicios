using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class MiClase
    {
        int a;
        int b;
        int c;

        public MiClase()
        {
            try
            {
                MiClase otroObjeto = new MiClase(0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"\nSegunda Excepcion -- UnaException  - - -\n {e}\n");
                // string exc = $"\nSegunda Excepcion -- Una Exception {e}\n";

                throw new UnaExcepcion(e);
            }
        }
        public MiClase(int a)
        {
            
            try
            {
               c= b / a;
            }
            catch (DivideByZeroException x)
            {
                Console.WriteLine($"\nPrimer Excepcion - - - - \n{x}");
                LanzarExcepcion();
            }
        }

     
        public static void LanzarExcepcion()
        {
           
            throw new DivideByZeroException();

        }

    }
}
