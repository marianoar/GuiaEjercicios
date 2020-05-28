using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

        public string Ficha(Equipo equipo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(equipo.nombre);
            sb.Append(" fundado el ");
            sb.Append(equipo.fechaCreacion);
            return sb.ToString();
        }
     

    }
}
