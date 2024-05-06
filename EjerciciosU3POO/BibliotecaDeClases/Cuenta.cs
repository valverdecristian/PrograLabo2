using System.Text;

namespace BibliotecaDeClases
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular ()
        {
            return this.titular;
        }

        public decimal GetCantidad ()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {GetTitular()}");
            sb.AppendLine($"Monto actual de la cuenta: {GetCantidad()}");

            return sb.ToString();
        }

        public void Ingresar(decimal ingreso)
        {
            if( ingreso <= 0 )
            {
                throw new ArgumentException("El monto a ingresar no puede ser negativo");
            }
            this.cantidad += ingreso;
        }

        public void Retirar(decimal retirar)
        {
            this.cantidad -= retirar;
        }
    }
}