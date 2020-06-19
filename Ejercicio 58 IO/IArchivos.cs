﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_58_IO
{
    interface IArchivos <T>
    {
        bool Guardar(string ruta, T objeto);

        bool GuardarComo (string ruta, T objeto);

        T Leer(string ruta);
    }
}
