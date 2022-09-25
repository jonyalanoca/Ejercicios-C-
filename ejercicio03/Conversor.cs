using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    public static class Conversor
    {
        
        private static string VoltearString(string valor)
        {
            string aux="";
            for(int i=valor.Length; i >0; i--)
            {
                aux = aux + valor[i-1];
            }
            return aux;
        }
        public static string ConvertirDecimalABinario(int numEntero)
        {
            bool fin = true;
            int aux;
            string enBinario = "";
            while (fin)
            {
                aux = numEntero % 2;
                numEntero = numEntero / 2;
                enBinario = enBinario + aux;
                if(numEntero==0 || numEntero == 1)
                {
                    enBinario = enBinario + numEntero;
                    fin = false;

                }
            }
            return VoltearString(enBinario);
        }
        public static int ConvertirBinarioADecimal(int numEntero)
        {
            string aux=VoltearString(numEntero.ToString());
            int suma = 0;
            for(int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == '1')
                {
                    suma+= (int)Math.Pow(2,i);
                }
            }
            return suma;
        }

    }
}
