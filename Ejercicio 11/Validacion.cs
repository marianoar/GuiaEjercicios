using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Validacion
    {
        public static bool Validar (int number, int min, int max)
        {
            if ((number < min) || (number > max)){
                return false;
            }
            return true;
        }
    }
}
