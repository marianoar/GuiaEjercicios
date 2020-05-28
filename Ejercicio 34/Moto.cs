using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Moto : VehiculoTerrestre
    {
       // private short cantidadRuedas;
        private short cilindrada;

        public short Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas: cantidadRuedas, cantidadPuertas: cantidadPuertas, color: color)
        {
            Cilindrada = cilindrada;
        }
    }
}
