using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        string nombre;

        Random a = new Random();
        Random b = new Random();

        public List<T> Equipos
        {
            get { return equipos; }
            set { equipos = value; }
        }


        /*
        public static bool operator ==(T equipoA, T equipoB)
        {
           if((equipoA.Nombre==equipoB.Nombre) && (equipoA.FechaCreacion == equipoB.FechaCreacion))
            {
                return true;
            }
            else
            {
                return false;
            }
 
         
        }
        public static bool operator !=()
        {
          
        }
    public string Mostrar()
        {
            return "";

        }*/

        private void CalculaPartido(T a, T b)
        {
            Random aux = new Random();
        }

        public string JugarPartido{
            get
            {
                a.Next(1, equipos.Count);
                b.Next(1, equipos.Count);
                for (int i = 0; i < equipos.Count; i++)
                {

                }
                return CalculaPartido();
               
                


            }
         }

    }
}
