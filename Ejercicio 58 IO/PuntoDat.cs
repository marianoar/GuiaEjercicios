using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_58_IO
{
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }

        public bool Guardar(string ruta, PuntoDat objeto)
        {
            return true;
        }
        public bool GuardarComo(string ruta, PuntoDat objeto)
        {
            return true;

        }

        public PuntoDat Leer(string ruta)
        {

            return new PuntoDat();

        }

        public override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            return false;

        }

    }
    
}
