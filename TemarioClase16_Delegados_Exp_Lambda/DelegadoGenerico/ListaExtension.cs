using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoGenerico
{
    // public delegate bool DelegadoCriterio<T>(T elemento);
    public static class ListaExtension
    {
        // extender una instancia, para este metodo de extension se usa el this en el 1er parametro
        // estoy haciendo un "where"
        public static List<T> Filtrar<T>(this List<T> lista, Predicate<T> criterioDeFiltrado)
                                    // tambien se puede usar Func<T, bool> criterioDeFiltrado
        {
            List<T> listaFiltrada = new List<T>();

            foreach (var item in lista)
            {
                if (criterioDeFiltrado(item))
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }
    }
}
