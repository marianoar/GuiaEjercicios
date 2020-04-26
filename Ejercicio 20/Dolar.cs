using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private double cotizRespectoDolar;

        private Dolar()
        {

        }

        public Dolar (double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public Dolar (double cantidad, double cotizRespectoDolar):this (cantidad)
        {
            this.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Euro (Dolar d)
        {
            return d;
        }
        public static explicit operator Pesos(Dolar d)
        {

        }

        public static implicit operator Dolar (double d)
        {

        }

        public static bool operator != (Dolar d, Euro e)
        {

        }

        public static bool operator ==(Dolar d, Euro e)
        {

        }

        public static bool operator != (Dolar d, Pesos p)
        {

        }
        public static bool operator ==(Dolar d, Pesos p)
        {

        }

        public static bool operator !=(Dolar d1,Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if(d1.cantidad == d2.cantidad)
            {
                return true;
            }
            return false;
        }

        public static Dolar operator - (Dolar d, Euro e)
        {

        }

        public static Dolar operator +(Dolar d, Euro e)
        {

        }

        public static Dolar operator - (Dolar d, Pesos p)
        {

        }

        public static  Dolar operator +(Dolar d, Pesos p)
        {

        }
    }
}
