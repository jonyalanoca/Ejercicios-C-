using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_ejercicio1_Entidades
{
    public abstract class VeiculoTerreste
    {
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected EColores color;
        protected short cantidadMarchas;
        public VeiculoTerreste(short ruedas, short puertas, EColores color)
        {
            this.cantidadRuedas = ruedas;
            this.cantidadPuertas = puertas;
            this.color = color;
        }
        public VeiculoTerreste(short ruedas, short puertas, EColores color, short marchas):this(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ruedas: {this.cantidadRuedas}");
            sb.AppendLine($"Puertas: {this.cantidadPuertas}");
            sb.AppendLine($"Color: {this.color.ToString()}");
            return sb.ToString();
        }

    }
}
