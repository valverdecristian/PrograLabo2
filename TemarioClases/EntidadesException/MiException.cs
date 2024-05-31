using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesException
{
    public class MiException : Exception
    {
        public MiException(string mensaje) : base(mensaje) { }
        public MiException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
