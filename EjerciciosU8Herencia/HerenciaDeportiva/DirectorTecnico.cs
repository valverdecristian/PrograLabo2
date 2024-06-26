﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDeportiva
{
    internal class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre):base(nombre)
        {}

        public DirectorTecnico(string nombre, DateTime fechaNacimiento):this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Fecha de Nacimiento: {fechaNacimiento}");

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Nombre == dt2.Nombre && dt1.fechaNacimiento == dt2.fechaNacimiento;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }

    }
}
