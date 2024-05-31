using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        List<Mascota> _manada;
        string _nombre;
        static ETipoManada _tipo;
        
        static Grupo()
        {
            _tipo = ETipoManada.Unica;
        }

        private Grupo()
        {
            _manada = new List<Mascota>();
        }


        public Grupo(string nombre) : this()
        {
            _nombre = nombre;
        }

        public Grupo(string nombre, ETipoManada tipo) : this(nombre) // uso la propiedad en vez de _tipo
        {
            _tipo = tipo;
        }

        public ETipoManada Tipo
        {
            set { _tipo = value; }
        }

        public static bool operator ==(Grupo grupo, Mascota mascota)
        {
            return grupo._manada.Contains(mascota);
        }

        public static bool operator !=(Grupo grupo, Mascota mascota)
        {
            return !(grupo == mascota);
        }

        public static Grupo operator +(Grupo grupo, Mascota mascota)
        {

            if (grupo != mascota)
            {
                grupo._manada.Add(mascota);
            }
            else
            {
                Console.WriteLine("La mascota ya forma parte del grupo.");
            }
            
            return grupo;
        }

        public static Grupo operator -(Grupo grupo, Mascota mascota)
        {
            if (grupo == mascota)
            {
                grupo._manada.Remove(mascota);
            }
            else
            {
                Console.WriteLine("La mascota no forma parte del grupo.");
            }

            return grupo;
        }

        public static implicit operator string (Grupo grupo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*** MANADA: {grupo._nombre}");
            sb.AppendLine($"Tipo : {_tipo}");
            sb.AppendLine("Mascotas:");
            foreach (var mascota in grupo._manada)
            {
                sb.AppendLine(mascota.ToString());
            }
            return sb.ToString();
        }
    }
}
