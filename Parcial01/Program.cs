using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial01
{
    class Program
    {
        static void Main(string[] args)
        {
            OtroNamespace.Boligrafo unBoligrafo = new OtroNamespace.Boligrafo(5, "BIC", "NEGRO");

            unBoligrafo.Mostrar();
        }
    }
}
