using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c7_Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public List<AutoF1> Competidores
        {
            get { return this.competidores; }
        }
        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores;}
        }
        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.Competidores.Contains(a);
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
        public static bool operator+(Competencia c, AutoF1 a)
        {
            bool exito = false;
            if (c.CantidadCompetidores > c.Competidores.Count && c!=a)
            {
                exito = true;
                c.Competidores.Add(a);
                CambiarDatos(a,c.CantidadVueltas);
            }
            return exito;
        }
        public static bool operator-(Competencia c, AutoF1 a)
        {
            bool exito = false;
            if (c == a)
            {
                c.Competidores.Remove(a);
                exito = true;
            }
            return exito;
        }
        private static void CambiarDatos(AutoF1 a, short cant)
        {
            Random aleatorio = new Random();
            a.EnCompetencia = true;
            a.VueltasRestantes = cant;
            a.CantidadCombustible = (short)aleatorio.Next(15, 101);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos de la competencia");
            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            foreach(AutoF1 i in this.competidores)
            {
                sb.AppendLine(i.MostrarDatos());
            }
            return sb.ToString();
        }
    }
}
