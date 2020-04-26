using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador (int cantidadSumas) : this()
        {

        }
        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public long Sumar (long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }

        public string Sumar (string a , string b)
        {
            cantidadSumas++;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" " + a);
            sb.AppendLine(" " + b);
            return sb.ToString();
        }

        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }
        public static bool operator | (Sumador s1, Sumador s2)
        { 
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }
            return false;
        }

        public static long operator + (Sumador s1, Sumador s2)
        {
            long aux=0;
            aux = s1.cantidadSumas + s2.cantidadSumas;
            return aux;
        }
    }
}
