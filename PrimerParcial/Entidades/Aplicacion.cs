using System.Text;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo
        {
            get { return sistemaOperativo; }
        }

        protected abstract int Tamanio
        {
            get;
        }

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Sistema Operativo: {sistemaOperativo}");
            sb.AppendLine($"Tamanio: {tamanioMb}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"Nombre de la aplicacion: {nombre}";
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp is not null)
            {
                foreach (var item in listaApp)
                {
                    if(item.nombre == app.nombre)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (listaApp == app)
            {
                return false;
            }
            else
            {
                listaApp.Add(app);
                return true;
            }

        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int maximoTamanio = int.MinValue;
            Aplicacion aplicacionMasPesada = null;

            foreach (Aplicacion app in listaApp)
            {
                if (app.Tamanio > maximoTamanio)
                {
                    maximoTamanio = app.Tamanio;
                    aplicacionMasPesada = app;
                }
            }

            return aplicacionMasPesada;
        }
    }
}