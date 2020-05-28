using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class UnaExcepcion:Exception
    {

        public static string Mostrar()
        {
            string mensaje = "- - - - - Catch Segunda Excepcion";
            return mensaje; 
        }
    }
}
