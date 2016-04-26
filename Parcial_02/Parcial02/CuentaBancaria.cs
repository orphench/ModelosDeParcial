using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    class CuentaBancaria
    {
        private string _nombreDelCliente;
        private Int32 _numeroCuenta;
        private double _saldo;

        public CuentaBancaria(Int32 numeroDeCuenta, string nombreDelCliente)
        {
            this._numeroCuenta = numeroDeCuenta;
            this._nombreDelCliente = nombreDelCliente;
        }

        public CuentaBancaria(Int32 numeroDeCuenta, string nombreDelCliente, double saldo)
        {
            this._numeroCuenta = numeroDeCuenta;
            this._nombreDelCliente = nombreDelCliente;
            this._saldo = saldo;
        }

        public void Mostrar()
        {
            Console.WriteLine("NUMERO: " + this._numeroCuenta + "  NOMBRE: " + this._nombreDelCliente + "  SALDO: " + this._saldo);
        }

        public static double operator +(CuentaBancaria primeraCuenta, CuentaBancaria segundaCuenta)
        {

            if (primeraCuenta._nombreDelCliente == segundaCuenta._nombreDelCliente)
            {
                double importeTotal = primeraCuenta._saldo + segundaCuenta._saldo;

                return importeTotal;
            }

            else 
            {
                Console.WriteLine("Las cuentas son de diferentes personas");
                return 0;
            }
            
        }

        public static CuentaBancaria operator +(CuentaBancaria unaCuenta, double unImporte)
        {
            unaCuenta._saldo = unaCuenta._saldo + unImporte;

            return unaCuenta;
        }

        public static CuentaBancaria operator -(CuentaBancaria unaCuenta, double unImporte)
        {
            if (unaCuenta._saldo > 0)
            {
                unaCuenta._saldo = unaCuenta._saldo - unImporte;
                return unaCuenta;
            }

            else
            {
                Console.WriteLine("No tiene saldo para realizar la operacion");
                return unaCuenta;
            }
        }
    }
}
