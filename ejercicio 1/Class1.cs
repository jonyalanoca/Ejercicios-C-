using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    public static  class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool enRango = false;
            if (valor >= -100 && valor <= 100)
            {
                enRango = true;
            }
            return enRango;
        }
    }
}
