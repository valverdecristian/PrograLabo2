namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Peso()
        {
            cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion):this(cantidad) // aun no entiendo su funcion
        {
            cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return cotzRespectoDolar;
        }

        public static double GetCotzRespectoDolar()
        {
            return cotzRespectoDolar;
        }

        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / GetCotzRespectoDolar());
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }



    }
}