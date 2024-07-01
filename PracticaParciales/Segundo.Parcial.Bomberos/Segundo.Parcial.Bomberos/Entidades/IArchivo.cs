using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo <X>
    {
        // recordar que no es necesario el public
        X Leer();
        void Guardar(X info);
    }
}
