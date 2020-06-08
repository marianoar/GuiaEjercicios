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
        string texto;
        public UnaExcepcion(Exception e) : base()
        {
            
           
        }
       
    }
}
