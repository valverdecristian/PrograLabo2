using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        short cantidadCombustible;
        bool enCompetencia;
        short numero;
        string? escuderia;
        short vueltasRestantes;

        public AutoF1(short numero, string? escuderia)
        {
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;

            this.numero = numero;
            this.escuderia = escuderia;
        }

        public short GetCantidadCombustible()
        {
            return cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return vueltasRestantes;
        }

        public void SetCantidadCombustible(short nuevaCantidad)
        {
            cantidadCombustible = nuevaCantidad;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero: {numero}");
            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"En Competencia: {enCompetencia}");
            sb.AppendLine($"Cantidad de combustible: {cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            return auto1.escuderia == auto2.escuderia && auto1.numero == auto2.numero;
        }

        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
    }
}
