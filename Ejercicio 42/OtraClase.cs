using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class OtraClase
    {
        public OtraClase()
        {
            try
            {
                new MiClase();
            }
            catch(UnaExcepcion ex)
            {
               // Console.WriteLine("mi excepcion");
                throw new MiExcepcion(ex);
            }
        }


    }
}

