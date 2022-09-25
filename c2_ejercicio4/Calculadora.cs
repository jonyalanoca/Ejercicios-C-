using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c2_ejercicio4
{
    public static class Calculadora
    {
        public static float Calcular(int operando1, int operando2, char operacion)
        {
            float resultado=0;
            switch (operacion)
            {
                case '+':
                    resultado = operando1 + operando2;
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    break;
                case '/':
                    if (Validar(operando2))
                    {
                        resultado = operando2 /operando1;
                    }
                    else
                    {
                        Console.WriteLine("Error division por cero");
                    }
                    break;
                case '*':
                        resultado=(float)operando1*operando2;
                    break;
                default:
                    Console.WriteLine("Caracter Incorrecto");
                    break;
            }
            return resultado;
        }
        private static bool Validar(int operando2)
        {
            if(operando2 != 0)
            {
                return true;
            }
            return false;
        }
    }
}
