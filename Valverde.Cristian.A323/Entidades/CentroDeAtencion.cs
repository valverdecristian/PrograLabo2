using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentroDeAtencion
    {
        private int cantRecsPorSuper;
        private List<Empleado> empleados;
        private string nombre;

        public List<Empleado> Empleados
        {
            get
            {
                return empleados;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public CentroDeAtencion(string nombre, int cantRecsPorSuper)
        {
            this.nombre = nombre;
            this.cantRecsPorSuper = cantRecsPorSuper;
            this.empleados = new List<Empleado>();
        }

        public string ImprimirNomina()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nomina del Centro de Atencion {Nombre}:");
            foreach (var empleado in Empleados)
            {
                sb.AppendLine(empleado.ToString());
            }
            return sb.ToString();
        }

        public static bool operator ==(CentroDeAtencion c, Empleado e)
        {
            return c.empleados.Contains(e);
        }

        public static bool operator !=(CentroDeAtencion c, Empleado e)
        {
            return !(c == e);
        }

        public static bool operator +(CentroDeAtencion c, Empleado e)
        {
            bool retorno = false;
            if (c != e)
            {
                if (e is Supervisor)
                {
                    if (c.ValidaCantidadDeRacs())
                    {
                        c.empleados.Add(e);
                        retorno = true;
                    }
                    else
                    {
                        Console.WriteLine("No se puede agregar el supervisor, no hay suficientes Racs.");
                    }
                }
                else
                {
                    c.empleados.Add(e);
                    retorno = true;
                }
            }
            return retorno;
        }

        public static string operator -(CentroDeAtencion c, Empleado e)
        {
            if (c == e)
            {
                e.HoraEgreso = DateTime.Now.TimeOfDay;
                if (e is Rac rac)
                {
                    return rac.EmitirFactura();
                }
                else if (e is Supervisor supervisor)
                {
                    return supervisor.EmitirFactura();
                }

                c.empleados.Remove(e);
            }
            return "Empleados no encontrado.";
        }

        private bool ValidaCantidadDeRacs()
        {
            int cantidadDeRacs = 0;
            int cantidadDeSupervisores = 0;

            foreach (var empleado in Empleados)
            {
                if (empleado is Rac)
                {
                    cantidadDeRacs++;
                }
                else if (empleado is Supervisor)
                {
                    cantidadDeSupervisores++;
                }
            }

            return cantidadDeRacs >= cantidadDeSupervisores * cantRecsPorSuper;
        }
    }
}
