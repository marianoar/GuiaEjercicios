using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Recibo : Documento
    {
        public Recibo()
        {
            Numero = 0;   
        }
        public Recibo(int numero)
        {
            Numero = numero;
        }
     
    }
}
