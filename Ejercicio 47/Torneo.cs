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

        public Torneo (string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
        }
        Random a = new Random();
        Random b = new Random();

        public List<T> Equipos
        {
            get { return equipos; }
            set { equipos = value; }
        }



        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            for (int i = 0; i < torneo.equipos.Count(); i++)
            {

                if ((torneo.equipos[i].Nombre == equipo.Nombre) && (torneo.equipos[i].FechaCreacion == equipo.FechaCreacion))
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
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return (!(torneo == equipo));
        }

        public static bool operator +(Torneo<T> torneo, T equipo) {
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            } else
            { return false;
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nTorneo: "+nombre);
            sb.AppendLine("\nEquipos inscriptos: ");
            for (int i = 0; i < this.equipos.Count(); i++)
            {
                sb.AppendLine(equipos[i].Nombre);
            }


            return sb.ToString();

        }

        private string CalculaPartido(T a, T b)
        {
            Random tantos = new Random();
            StringBuilder sb = new StringBuilder();
            sb.Append(a.Nombre + " : " + tantos.Next(0, 10) + " goles - "+ b.Nombre +" : "+ tantos.Next(0, 10) );
            return sb.ToString();
        }

        public string JugarPartido {
            get
            {
                int a= new Random().Next(0, equipos.Count);
                int b = new Random().Next(0, equipos.Count);
                while (a == b)
                {
                    b = new Random().Next(0, equipos.Count); 
                }

                return CalculaPartido(this.equipos[a], this.equipos[b]);
            }
        }
    }
}
   

