using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c4_Entidades
{
    public class Estante
    {
        private Producto[] productos;
        private int hubicacionDeEstantes;
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante(int capacidad,int hubicacion): this(capacidad)
        {
            this.hubicacionDeEstantes = hubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante est)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Detalle del estante numero {est.hubicacionDeEstantes}");
            foreach(Producto i in est.GetProductos())
            {
                sb.AppendLine($"{Producto.MostrarProducto(i)}");
            }
            sb.AppendLine("");
            return sb.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            return e.GetProductos().Contains(p);
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool contiene = false;
            if (e != p)
            {
                for(int i =0;i<e.GetProductos().Length;i++)
                {
                    if(e.GetProductos()[i] is null)
                    {
                        e.GetProductos()[i] = p;
                        contiene = true;
                        Console.WriteLine("Se agrego el Producto a la lista.");
                        break;
                    }
                }
            }
            return contiene;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for(int i=0; i < e.GetProductos().Length; i++)
                {
                    if (e.GetProductos()[i] == p)
                    {
                        e.GetProductos()[i] = null;
                        Console.WriteLine("Se elimino el producto de la lista");
                    }
                }
            }
            return e;
        }

    }
}
