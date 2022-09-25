using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace c8_ejercicio1_Entidades
{
    public class Automovil:VeiculoTerreste
    {
        private short cantidadPasajeros;
        public Automovil(short ruedas, short puertas, EColores color,short marchas, short pasajeros) : base(ruedas, puertas, color, marchas)
        {
            this.cantidadPasajeros = pasajeros;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos del auto");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Marchas: {this.cantidadMarchas}");
            sb.AppendLine($"Pasajeros: {this.cantidadPasajeros}");
            sb.AppendLine("");
            return sb.ToString();
        }
    }
    public class Camion : VeiculoTerreste
    {
        private int pesoCarga;
        public Camion(short ruedas, short puertas, EColores color, short marchas, short peso) : base(ruedas, puertas, color, marchas)
        {
            this.pesoCarga = peso;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos del Camion");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Marchas: {this.cantidadMarchas}");
            sb.AppendLine($"peso: {this.pesoCarga}");
            sb.AppendLine("");
            return sb.ToString();
        }
    }
    public class Moto : VeiculoTerreste
    {
        private short cilindrada;
        public Moto(short ruedas, short puertas, EColores color,short cilindrada) : base(ruedas, puertas, color)
        {
            this.cilindrada = cilindrada;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos de la moto");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            sb.AppendLine("");
            return sb.ToString();
        }
    }
}