using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Boligrafo : IAcciones
    {

        private ConsoleColor color;
        private float tinta;

        public Boligrafo(float tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor Color
        {
            get { return this.color; }
            set { throw new NotImplementedException(); }
        }
        public float UnidadesDeEscritura
        {
            get { return tinta; }
            set { }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                tinta -= 0.3F;
            }
            return new EscrituraWrapper(texto, Color); 
        }

        public bool Recargar(int unidades)
        {
            tinta += unidades;
           return true;
        }

        public override string ToString()
        {
            return "Esto es un Boligrafo de color "+ Color.ToString()+ " con  nivel de tinta en "+tinta.ToString();
        }
    }
}
