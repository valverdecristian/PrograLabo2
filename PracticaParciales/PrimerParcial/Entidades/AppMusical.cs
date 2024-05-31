using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        List<string> listaCanciones;

        // no olvidar esta parte
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial)
            :this(nombre, sistemaOperativo, tamanioInicial, new List<string>())
        {
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones)
            :base(nombre, sistemaOperativo, tamanioInicial)
        {
            if (listaCanciones is null)
            {
                this.listaCanciones = new List<string>();
            }
            else
            {
                this.listaCanciones = listaCanciones;
            }
        }

        protected override int Tamanio
        {
            get
            {
                int cantidadCanciones = listaCanciones.Count;
                int tamanioCanciones = cantidadCanciones * 2;
                int tamanioApp = tamanioCanciones + tamanioMb;

                return tamanioApp;

            }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());
            if(listaCanciones is not null)
            {
                sb.AppendLine($"Lista de canciones:");
                foreach (var item in listaCanciones)
                {
                    sb.AppendLine(item);
                }
            }

            return sb.ToString();
        }
    }
}
