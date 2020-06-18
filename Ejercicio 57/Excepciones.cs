using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
    public class Excepciones : Exception
    {
      
        public Excepciones() : base("No se guardo el archivo")
        {

        }
    }
}
