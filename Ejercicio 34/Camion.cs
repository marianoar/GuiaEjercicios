using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public short CantidadMarchas
        {
            get { return cantidadMarchas; }
            set { cantidadMarchas = value; }
        }
    public int PesoCarga
    {
        get { return pesoCarga; }
        set { pesoCarga = value; }
    }
        public Camion (short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga):base(cantidadRuedas:cantidadRuedas, cantidadPuertas:cantidadPuertas, color:color)
        {
            CantidadMarchas = cantidadMarchas;
            PesoCarga = pesoCarga;
            
        }
    }
}
