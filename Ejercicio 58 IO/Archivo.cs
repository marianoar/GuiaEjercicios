using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_58_IO
{
    public abstract class Archivo
    {
        public abstract bool ValidarArchivo(string ruta, bool validaExistencia);
    }
}
