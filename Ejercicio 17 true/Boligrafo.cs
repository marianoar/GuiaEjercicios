using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17_true
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor getColor()
        {
                return this.color;
        }
        public short getTinta()
        {
            return this.tinta;
        }

        /*public bool Pintar(short gasto, out string dibujo)
        {
        }*/

        public void Recargar()
        {

        }

        private void setTinta (short tinta)
        {
            short tintaActual;
            tintaActual = getTinta();

          //  this.tinta = tintaActual + tinta;

        }
    
    }
}
