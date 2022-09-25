using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades1
{
    public class Duenio
    {
        private string nombre;
        private string apellido;
        private double telefono;
        private List<Mascota> mascotas;
        public Duenio(string nombre, string apellido, double telefono, List<Mascota> mascotas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mascotas = mascotas;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos del cliente {this.nombre} {this.apellido}");
            sb.AppendLine($"Telefono: {this.telefono}");
            sb.AppendLine($"Mascotas:");
            foreach(Mascota i in mascotas)
            {
                sb.AppendLine(i.Mostrar());
            }
            sb.AppendLine($"");
            return sb.ToString();
        }
    }
}
