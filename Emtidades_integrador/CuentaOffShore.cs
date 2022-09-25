using Emtidades_integrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_integrador
{
    public  class CuentaOffShore
    {
        private Cliente dueño;
        private int numeroCuenta;
        private double saldo;
        public Cliente Dueño
        {
            get => dueño;set => dueño=value;
        }
        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }
        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this.dueño = dueño;
            this.numeroCuenta = numero;
            Saldo = saldoInicial;
        }
        public CuentaOffShore(string nombre, ETipoCliente tipo, int numero, double saldoInicial):this(new Cliente(tipo,nombre), numero, saldoInicial)
        {

        }
        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return cos1.numeroCuenta == cos2.numeroCuenta && cos1.dueño.GetAlias() == cos2.dueño.GetAlias();
        }
        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }
        public static explicit operator int(CuentaOffShore cos)
        {
            return cos.numeroCuenta; 
        }

    }
    
}
