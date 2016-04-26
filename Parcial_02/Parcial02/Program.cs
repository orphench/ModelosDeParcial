using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuenta;

namespace Parcial02
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria unaCuenta = new CuentaBancaria(111, "Pepito", 2000);
            CuentaBancaria otraCuenta = new CuentaBancaria(222, "Chano", 3000);

            double importeDouble = unaCuenta + otraCuenta;

            unaCuenta.Mostrar();

            unaCuenta = unaCuenta + 1600;

            unaCuenta.Mostrar();
            
            unaCuenta = unaCuenta - 1000;

            unaCuenta.Mostrar();

            Console.ReadKey();
        }
    }
}
