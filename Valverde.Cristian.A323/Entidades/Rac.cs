using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rac : Empleado
    {
        public enum EGrupo
        {
            CALL_IN,
            CALL_OUT,
            RRSS
        }

        private EGrupo grupo;
        private static double valorHora;

        public EGrupo Grupo
        {
            get { return grupo; }
        }

        public static double ValorHora
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

        static Rac()
        {
            valorHora = 875.90f;
        }

        public Rac(string legajo, string nombre, TimeSpan horaIngreso)
            : base(legajo, nombre, horaIngreso)
        {
            this.grupo = EGrupo.CALL_IN;
        }

        public Rac(string legajo, string nombre, TimeSpan horaIngreso, EGrupo grupo)
            : this (legajo, nombre, horaIngreso)
        {
            this.grupo = grupo;
        }

        public string EmitirFactura()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Factura de: {this}\nImporte a facturar: {Facturar()}");
            return sb.ToString();
        }

        private double CalcularBonoDeGrupo()
        {
            double bono = 0d;
            if (Grupo == EGrupo.CALL_IN)
            {
                bono = 0d;
            }
            else if(Grupo == EGrupo.CALL_OUT)
            {
                bono = 0.1d;
            }
            else if(Grupo == EGrupo.RRSS)
            {
                bono = 0.2d;
            }

            return bono;
        }

        protected override double Facturar()
        {
            double bono = CalcularBonoDeGrupo();
            return base.Facturar() * ValorHora * (1 + bono);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {grupo} - {legajo} - {nombre}";
        }
    }
}
