using System.Text;

namespace Emtidades_integrador
{
    public class Cliente
    {
        private string aliasParaIncognito;
        private string nombre;
        private ETipoCliente tipoDeCliente;
        private Cliente()
        {
            this.aliasParaIncognito = "NN";
            this.tipoDeCliente = ETipoCliente.SinTipo;
        }
        public Cliente(ETipoCliente tipoDeCliente):this()
        {
            this.tipoDeCliente=tipoDeCliente;
        }
        public Cliente(ETipoCliente tipoDeCliente, string nombre) : this()
        {
            this.nombre = nombre;
        }
        private void CrearAlias()
        {
            Random rd = new Random();
            StringBuilder sb=new StringBuilder();
            sb.Append($"{rd.Next(1000, 9999)}{tipoDeCliente.ToString()}");
            this.aliasParaIncognito = sb.ToString();
        }
        public string GetAlias()
        {
            if (tipoDeCliente == ETipoCliente.SinTipo)
            {
                CrearAlias();
            }
            return this.aliasParaIncognito;
        }
        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Datos de cliente.\nNombre: {this.nombre}\nAlias: {this.aliasParaIncognito}\nTipo de cliente: {this.tipoDeCliente.ToString()}");
            return sb.ToString();
        }
        public string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }
    }
    
}