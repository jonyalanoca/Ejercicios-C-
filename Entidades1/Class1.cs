using System.Text;

namespace Entidades1
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;
        public Cuenta()
        {
            this.titular = "nadie";
            this.cantidad = 0;
        }
        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitutlar()
        {
            return this.titular;
        }
        public int GetCantidad()
        {
            return this.cantidad;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El titular es {this.titular}");
            sb.AppendLine($"La cantidad de la cuenta es: {this.cantidad}");
            return sb.ToString();
        }
        public void IngresarMonto(int moneda)
        {
            if (moneda > 0) {
                this.cantidad += moneda;
            }
        }
        public void RetirarMonto(int moneda)
        {
            this.cantidad -= moneda;
        }
    }
    
}