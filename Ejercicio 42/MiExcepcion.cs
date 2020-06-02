using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class MiExcepcion: Exception
    {
        public MiExcepcion(UnaExcepcion e) : this()
        {
            
        }

        public MiExcepcion() : base()
        {
        
        }

    }
}
