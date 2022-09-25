using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades1
{
    public class Conductores
    {
        private string nombre;
        private Dictionary<string, int> kmRecorridosPorDias;
        public Conductores(string nombre, int dia1, int dia2, int dia3, int dia4, int dia5, int dia6, int dia7)
        {
            this.nombre = nombre;
            this.kmRecorridosPorDias = new Dictionary<string, int>();
            this.kmRecorridosPorDias.Add("Día 1", dia1);
            this.kmRecorridosPorDias.Add("Día 2", dia2);
            this.kmRecorridosPorDias.Add("Día 3", dia3);
            this.kmRecorridosPorDias.Add("Día 4", dia4);
            this.kmRecorridosPorDias.Add("Día 5", dia5);
            this.kmRecorridosPorDias.Add("Día 6", dia6);
            this.kmRecorridosPorDias.Add("Día 7", dia7);
        }
        public string Nombre
        {
            get { return this.nombre;
            }
        }
        public int KMRecorridos()
        {
            int total = 0;
            foreach(var i in this.kmRecorridosPorDias)
            {
                total += i.Value;
            }
            return total;
        }
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Recorrido del conductor {this.nombre}:");
            foreach (var i in this.kmRecorridosPorDias)
            {
                sb.AppendLine($"{i.Key}: {i.Value}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
