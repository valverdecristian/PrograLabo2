using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Supervisor : Empleado
    {
        private static float valorHora;

        public static float ValorHora
        {
            get
            {
                return valorHora;
            }
            set
            {
                if (value > 0)
                {
                    valorHora = value;
                }
            }
        }

        static Supervisor()
        {
            valorHora = 1025.50f;
        }

        private Supervisor(string legajo)
            : base (legajo, "n/a", new TimeSpan(9,0,0))
        {

        }

        public Supervisor(string legajo, string nombre, TimeSpan horaIngreso)
            : this(legajo)
        {
            this.nombre = nombre;
            this.horaIngreso = horaIngreso;
        }

        public string EmitirFactura()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Factura de: {this}\nImporte a facturar: {Facturar()}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{GetType().Name} - {legajo} - {nombre}";
        }

        protected override double Facturar()
        {
            // double totalHoras = (horaEgreso - horaIngreso).TotalHours;
            return base.Facturar() * ValorHora;
        }

        public static implicit operator Supervisor(string legajo)
        {
            return new Supervisor(legajo);
        }

    }
}
