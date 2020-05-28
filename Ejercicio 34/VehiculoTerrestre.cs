using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected Colores color;

        public short CantidadRuedas
        {
            get
            {
                return cantidadRuedas;
            }
            set { cantidadRuedas = value; }
        }
        public short CantidadPuertas
        {
            get { return cantidadPuertas; }
            set { cantidadPuertas = value; }

        }
        public Colores Color{
            get { return color; }
            set { color = value; }
            }
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            CantidadRuedas = cantidadRuedas;
            CantidadPuertas = cantidadPuertas;
        }
    }
}
