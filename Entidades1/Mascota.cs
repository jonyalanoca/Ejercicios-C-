using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades1
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime nacimiento;
        private List<EVacuna> vacunas;
        public Mascota(string nombre, string especie, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.nacimiento = nacimiento;
            this.vacunas = new List<EVacuna>() { EVacuna.Ninguna};
        }
        public Mascota(string nombre, string especie, DateTime nacimiento, List<EVacuna> vacunas) : this(nombre, especie, nacimiento)
        {
            this.vacunas = vacunas;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos de {this.nombre}");
            sb.AppendLine($"Especie: {this.especie}");
            sb.AppendLine($"Nacimiento: {this.nacimiento}");
            sb.Append($"Vacunas: ");
            foreach (var i in vacunas)
            {
            sb.Append($"{i.ToString()}  ");

            }
            sb.AppendLine("");
            return sb.ToString();
        }
    }
    
}
