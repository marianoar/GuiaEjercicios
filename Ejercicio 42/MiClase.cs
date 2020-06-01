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
        string b;



        public MiClase(int a) : this()
        {
            if (a == 0)
            {
                Lanzar();
            }
            else
                this.a = a;
        }

        public MiClase()
        {

        }

        public static void Lanzar()
        {
         
            throw new DivideByZeroException();

        }

    }
}
