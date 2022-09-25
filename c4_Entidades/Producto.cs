using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c4_Entidades
{
    public class Producto
    {
        private string codigoDeBarras;
        private string marca;
        private float precio;
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarras = codigo;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static explicit operator string(Producto p)
        {
            return (string)p.codigoDeBarras;
        }
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Detalles del producto");
            sb.AppendLine($"Marca: {p.GetMarca()}");
            sb.AppendLine($"Precio: {p.GetPrecio()}");
            sb.AppendLine($"Codigo: {(string)p}");
            return sb.ToString();
        }
        public static bool operator ==(Producto prod1, Producto prod2)
        {
            return prod1.GetMarca() == prod2.GetMarca() && (string)prod1 == (string)prod2;
        }
        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }
        public static bool operator ==(Producto prod1, string marca)
        {
            return prod1.GetMarca() == marca;
        }
        public static bool operator !=(Producto prod1, string marca)
        {
            return !(prod1==marca);
        }

    }
}
