using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c7_2_Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public  static int NumeroActual
        {
            get {
                PuestoAtencion.numeroActual++;
                return PuestoAtencion.numeroActual; 
            }
        }
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        public bool Atender(Cliente cli)
        {
            Thread.Sleep(3000);
            return true;
        }

           
    }
}
