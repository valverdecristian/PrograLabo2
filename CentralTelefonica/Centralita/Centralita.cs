using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        private List<Llamada>? listaDeLlamadas;
        protected string? razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }


        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float retorno = 0;

            foreach (var item in listaDeLlamadas)
            {
                if (item is Local l)
                {
                    gananciaLocal += l.CostoLlamada;
                }
                else if (item is Provincial p)
                {
                    gananciaProvincial += p.CostoLlamada;
                }
            }

            switch (tipo)
            {
                case TipoLlamada.Local:
                    retorno = gananciaLocal;
                    break;
                case TipoLlamada.Provincial:
                    retorno = gananciaProvincial;
                    break;
                case TipoLlamada.Todas:
                    retorno = gananciaLocal + gananciaProvincial;
                    break;
                default:
                    break;
            }

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {razonSocial}");

            return sb.ToString();
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
            set
            {
                listaDeLlamadas = value;
            }
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }


    }
}
