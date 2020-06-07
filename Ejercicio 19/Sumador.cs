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

        public int CantidadSumas
        {
            get { return cantidadSumas; }
        }
        public Sumador (int cantidadSumas) : this()
        {
            this.cantidadSumas = cantidadSumas;
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
            sb.Append(a);
            sb.AppendLine(" " + b);
            return sb.ToString();
        }
        /*c. Generar una conversión explícita que retorne cantidadSumas.
            d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
            con dicho valor.
            e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
            cantidadSumas*/
        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
            
        }
        public static bool operator | (Sumador s1, Sumador s2)
        { 
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }
            return false;
        }

      
    }
}
