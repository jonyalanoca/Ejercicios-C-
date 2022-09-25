using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c7_2_Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        public Cliente Cliente
        {
            get {

                    return this.clientes.Peek();

            }
            set { this.clientes.Enqueue(value); }
        }
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }
        public Negocio(string nombre) : this()
        {
            this.nombre =nombre;
        }
        public static bool operator==(Negocio n, Cliente c)
        {
            return n.clientes.Contains(c);
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n==c);
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            bool exito = false;
            if (n != c)
            {
                n.Cliente= c;
                exito=true;
            }
            return exito;
        }
        public static bool operator ~(Negocio n)
        {
            bool exito = false;
            if(n.clientes.Count > 0)
            {
                Console.WriteLine($"Se atienede a: {n.Cliente.Nombre}");
                if (n.caja.Atender(n.Cliente) == true)
                {
                    n.clientes.Dequeue();
                    exito = true;
                }
            }
            
            return exito;
        }
        public int ClientesPendientes()
        {
            return this.clientes.Count;
        }

    }
}
