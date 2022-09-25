using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c7_Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        public AutoF1(short numero, string escuderia)
        {
            this.escuderia= escuderia;
            this.numero = numero;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }
        public static bool operator==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero && String.Compare(a1.escuderia,a2.escuderia)==0;
        }
        public bool EnCompetencia
        {
            set { this.enCompetencia = value; }
        }
        public short VueltasRestantes
        {
            set { this.vueltasRestantes = value; }
        }
        public short CantidadCombustible
        {
            set { this.cantidadCombustible = value; }
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public string MostrarDatos()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Datos del auto");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"escuderia: {this.escuderia}");
            sb.AppendLine($"cantidad de combustible: {this.cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");
            sb.AppendLine("");
            return sb.ToString();
        }

    }
}
