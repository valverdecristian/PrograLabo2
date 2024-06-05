namespace Entidades
{
    public abstract class Empleado
    {
        protected TimeSpan horaEgreso;
        protected TimeSpan horaIngreso;
        protected string legajo;
        protected string nombre;

        protected Empleado(string legajo, string nombre, TimeSpan horaIngreso)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.horaIngreso = horaIngreso;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Legajo
        {
            get
            {
                return legajo;
            }
        }

        public TimeSpan HoraIngreso
        {
            get
            {
                return horaIngreso;
            }
        }

        public TimeSpan HoraEgreso
        {
            get
            {
                return horaEgreso;
            }
            set
            {
                horaEgreso = ValidarHoraEgreso(value);
            }
        }

        protected virtual double Facturar()
        {
            return (HoraEgreso - HoraIngreso).TotalHours;
        }

        private TimeSpan ValidarHoraEgreso(TimeSpan horaEgreso)
        {
            if(horaEgreso > HoraIngreso)
            {
                return horaEgreso;
            }

            return DateTime.Now.TimeOfDay;
        }

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return e1.Legajo == e2.Legajo;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
    }
}