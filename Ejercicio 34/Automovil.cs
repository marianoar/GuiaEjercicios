using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadMarchas, int cantidadPasajeros, short cantidadRuedas, short cantidadPuertas,Colores color):base(cantidadRuedas:cantidadRuedas, cantidadPuertas:cantidadPuertas,color:color)
        {
           this.cantidadMarchas=cantidadMarchas;
         this.cantidadPasajeros=cantidadPasajeros;
        }
        public short CantidadMarchas
        {
            get { return cantidadMarchas; }
            set { cantidadMarchas = value; }
        }
        public int CantidadPasajeros
        {
            get { return cantidadPasajeros; }
            set { cantidadPasajeros = value; }
        }


    }
}
