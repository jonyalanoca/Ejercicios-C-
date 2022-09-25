using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades1
{
    public class Transporte
    {
        List<Conductores> condList;
        public Transporte()
        {
            this.condList = new List<Conductores>();
        }
        public static Transporte operator+(Transporte transp, Conductores cond)
        {
            transp.condList.Add(cond);
            Console.WriteLine($"Se agrego el conductor {cond.Nombre}");
            return transp;
        }
        public string ConductorConMasKM()
        {
            bool bandera=false;
            Conductores maxCond=null;
            int kmMax=0;
            foreach(Conductores i in this.condList){
                if (bandera == false)
                {
                    maxCond = i;
                    bandera = true;
                    kmMax = i.KMRecorridos();
                }
                else
                {
                    if (kmMax < i.KMRecorridos())
                    {
                        maxCond = i;
                        kmMax = i.KMRecorridos();
                    }

                }
            }
            return maxCond.Nombre;
        }
    }
}
