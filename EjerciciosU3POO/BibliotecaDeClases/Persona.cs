using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public void SetFechaNacimiento(DateTime nuevaFecha)
        {
            fechaNacimiento = nuevaFecha;
        }

        public int GetDni()
        {
            return dni;
        }

        public void SetDni(int nuevoDNI)
        {
            dni = nuevoDNI;
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // la fecha de nacimiento no puede ser mayor a la fecha actual
            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        public string Mostrar()
        {
            int edad = CalcularEdad();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Fecha de Nacimiento: {fechaNacimiento.ToString()}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Edad: {edad} años");

            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad();
            return (edad >= 18) ? "Es mayor de edad" : "Es menor de edad";
        }

    }
}
