using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public  ConsoleColor Color
        {
            get { return ConsoleColor.Red; }
            set { throw new NotImplementedException(); }
        }

        public float UnidadesDeEscritura
        {
            get { return tamanioMina; }
            set { }
        }

        public EscrituraWrapper Escribir(string texto) // por que aca no puedo hacer explicito?
        {
            float reducir = texto.Length * (float)0.1;

            tamanioMina = tamanioMina - reducir;
            
            
            return new EscrituraWrapper(texto, Color);

        }
        public Lapiz(int unidades)
        {
            tamanioMina = unidades;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
  
        }

        public override string ToString()
        {
            return "Esto es un Lapiz de color " + Color.ToString() + " con tamanio mina en " + tamanioMina.ToString();
        }

    }
}
