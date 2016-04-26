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
            List<Boligrafo> miLista = new List<Boligrafo>();
            Boligrafo UnBoligrafo = new Boligrafo("BLANCO", "BIC", 60);
            UnBoligrafo.Escribir(70);

            if (UnBoligrafo.RecargarTinta(90))
            {
                Console.WriteLine("Boligrafo Recargado");
            }
            else
            {
                Console.WriteLine("No se pudo recargar");
            }

            if (UnBoligrafo.RecargarTinta())
            {
                Console.WriteLine("Boligrafo Recargado");
            }
            else
            {
                Console.WriteLine("No se puedo recargar");
            }

            miLista = miLista + UnBoligrafo;

            Boligrafo boligrafo2 = new Boligrafo("ROJO", "SILVAPEN", 50);
            miLista.Add(boligrafo2);

            //miLista = miLista - UnBoligrafo;

            Console.WriteLine("                  Muestro :");
            Boligrafo.MostrarBoligrafos(miLista);
            Console.ReadLine();

            Console.WriteLine("                  Sumo :");
            Boligrafo otroBoligrafo = new Boligrafo("VERDE", "PARKER", 60);
            miLista = miLista + otroBoligrafo;
            Boligrafo.MostrarBoligrafos(miLista);
            Console.ReadLine();
       
            Console.WriteLine("                  Resto :");
            Boligrafo boligrafo3 = new Boligrafo(40, "VERDE", "PARKER");
            miLista = miLista - boligrafo3;
            Boligrafo.MostrarBoligrafos(miLista);

            Console.ReadKey();
        }
    }
}
