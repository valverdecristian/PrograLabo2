﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            return valor > min && valor < max;
        }

        public static bool ValidarRespuesta(string respuesta)
        {
            return respuesta == "s".ToUpper();
        }
    }
}
