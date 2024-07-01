using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Salida
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;
        
        public Salida()
        {
            // El constructor dará inicio a la salida colocando la fecha y hora actual en el atributo correspondiente.
            fechaInicio = DateTime.Now;
        }

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        public double TiempoTotal
        {
            // retornará la diferencia en segundos entre la fecha de inicio y la fecha de fin.
            get
            {
                return fechaInicio.CalcularDiferenciaEnSegundos(fechaFin);
            }
        }

        public void FinalizarSalida()
        {
            // dará fin a la salida colocar la fecha y hora actual en el atributo correspondiente
            fechaFin = DateTime.Now;
        }
    }
}
