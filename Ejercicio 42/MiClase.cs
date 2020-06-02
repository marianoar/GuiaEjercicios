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
        

        public MiClase(int a)
        {
            
            try
            {
               c= b / a;
            }
            catch (DivideByZeroException)
            {
                LanzarExcepcion();
            }
        }

        public MiClase()
        {
            try
            {
                MiClase otroObjeto = new MiClase(0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Segunda Excepcion -- Una Exception");
               // Console.WriteLine(e.Message);
                throw new UnaExcepcion(e);
            }
        }
        public static void LanzarExcepcion()
        {
            Console.WriteLine("Primer Excepcion - dividir por zero");

            throw new DivideByZeroException();

        }

    }
}
