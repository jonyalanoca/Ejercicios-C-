using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_integrador
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> listadoCuentas;
        private EParaisosFiscales lugar;
        private static int cantidadDeCuentas;
        private static DateTime fechaInicioActividades;
        static ParaisoFiscal()// ves esta parte si no lleva private o public(creo q no)
        {
            ParaisoFiscal.cantidadDeCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }
        private ParaisoFiscal()
        {
            listadoCuentas = new List<CuentaOffShore>();    
        }
        private ParaisoFiscal(EParaisosFiscales lugar) :this()
        {
            this.lugar = lugar;
        }
        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos Paraiso:");
            sb.AppendLine($"Fecha de inicio: {ParaisoFiscal.fechaInicioActividades}");
            sb.AppendLine($"Lugar de Radicacion: {this.lugar}");
            sb.AppendLine($"Cantidad de cuentas: {ParaisoFiscal.cantidadDeCuentas}");
            foreach(CuentaOffShore i in this.listadoCuentas)
            {
                i.Dueño.RetornarDatos(i.Dueño);
            }
            Console.WriteLine(sb.ToString());
        }
        public static implicit operator ParaisoFiscal (EParaisosFiscales epf)
        {
            return new ParaisoFiscal (epf);
        } 
        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return pf.listadoCuentas.Contains(cos);

        }
        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }
        public static ParaisoFiscal operator-(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf==cos)
            {
                pf.listadoCuentas.Remove(cos);
                ParaisoFiscal.cantidadDeCuentas--;

                Console.WriteLine("Se elimino una cuenta de paraiso fiscal.");
            }else
            {
                Console.WriteLine("La cuenta no existe. No se realizaron cambios.");
            }
            return pf;
        }
        public static ParaisoFiscal operator+(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf != cos)
            {
                pf.listadoCuentas.Add(cos);
                ParaisoFiscal.cantidadDeCuentas++;
                Console.WriteLine("Se agrego una cuenta a la lista de paraiso fiscal.");
            }
            else
            {
                Console.WriteLine("La cuenta ya existe. No se realizaron cambios.");
            }
            return pf;
        }




    }
}
