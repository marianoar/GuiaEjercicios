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

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "*";
            
            if (getTinta() == 0)
            {
                return false;
            }
           
            for (int i = 0; i < gasto; i++)
            {
                 Console.Write(dibujo);
            }
            
             return true;
            
        }

        public void Recargar()
        {
            setTinta(100);
        }

        private void setTinta (short tinta)
        {
            short tintaActual;
            tintaActual = getTinta();

            if (tinta > 0)
            {
                this.tinta=tintaActual -= tinta;
                if (this.tinta > 100)
                {
                    this.tinta = 100;
                }
            }
            else
            {
              /* this.tinta = tintaActual -= tinta;
                if (this.tinta < 0)
                {
                    this.tinta = 0;
                }*/
            }
          

        }
    
    }
}
