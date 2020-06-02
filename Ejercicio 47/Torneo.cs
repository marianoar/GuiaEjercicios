using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos = new List<T>();
        string nombre;

        Random a = new Random();
        Random b = new Random();

        public List<T> Equipos
        {
            get { return equipos; }
            set { equipos = value; }
        }



        public static bool operator ==(List<T> equipos, T equipo)
        {
            for (int i = 0; i < equipos.Count(); i++)
            {


                if ((equipos[i].Nombre == equipo.Nombre) && (equipos[i].FechaCreacion == equipo.FechaCreacion))
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
        public static bool operator !=(List<T> equipos, T equipo)
        {
          //  return (!(equipoA == equipoB));
        }

        public static implicit operator + (List<T> equipos, T equipo){

            }
    public string Mostrar()
        {
            return "";

        }

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
