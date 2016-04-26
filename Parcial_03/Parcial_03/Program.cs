using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melgar.Christopher;

namespace Parcial_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto autoDos = new Auto(EMarcas.Ferrari, "ROJO");
            Auto autoUno = new Auto(EMarcas.Ferrari, "AMARILLO");

            Auto autoTres = new Auto(2000, "BLANCO", EMarcas.Ford);
            Auto autoCuatro = new Auto(3000, "BLANCO", EMarcas.Ford);

            Auto autoCinco = new Auto(4000, DateTime.Now);
            Auto autoSeis = new Auto(EMarcas.Lotus, DateTime.Now);
            Auto autoSiete = new Auto(EMarcas.Lotus, "NEGRO", 4500);

            autoCinco.AgregarImpuestos(1000);
            autoSeis.AgregarImpuestos(1000);
            autoSiete.AgregarImpuestos(1000);

            Auto.MostrarAuto(autoCinco);
            Auto.MostrarAuto(autoSeis);
            Auto.MostrarAuto(autoSiete);

            double importeDouble = autoUno + autoDos;
            Console.WriteLine(importeDouble);

            if (autoUno == autoDos)
            {
                Console.WriteLine("Son Iguales");
            }

            else
            {
                Console.WriteLine("No son iguales");
            }

            Garage unGarage = new Garage("EL PLAYON", 50);

            unGarage.MostrarGarage();

            Console.ReadKey();
        }
    }
}
