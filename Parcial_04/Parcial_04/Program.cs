using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto ProductoUno = new Producto(666, "JamonDelDiablo", eTipoComestible.solido, 2);
            Producto ProductoDos = new Producto(33, "JamonDeDios", eTipoComestible.solido, 10);
            Producto ProductoTres = new Producto(55, "Sprite", eTipoComestible.liquido, 10);
            Producto ProductoCuatro = new Producto(666, "JamonDelDiablo", eTipoComestible.solido);

            Container ContenedorUno = new Container(2, "Skanka");
            Container ContenedorDos = new Container(3, "Skanka");
            List<Producto> listaProducto = new List<Producto>();

            ContenedorUno.Agregar(ProductoUno);
            ContenedorUno.Agregar(ProductoDos);
            if(! ContenedorUno.Agregar(ProductoTres))
            {
                Console.WriteLine("No se pudo");
            }

            ContenedorDos.Agregar(ProductoUno);
            ContenedorDos.Agregar(ProductoDos);
            if (!ContenedorDos.Agregar(ProductoCuatro))
            {
                Console.WriteLine("No se pudo");
            }
            ContenedorDos.Agregar(ProductoTres);

            Container.Mostrar(ContenedorUno);
            Container.Mostrar(ContenedorDos);

            listaProducto = ContenedorDos - eTipoComestible.liquido;

            Console.WriteLine("         Lista Extraida          ");
            foreach (Producto item in listaProducto)
            {
                item.Mostrar();
            }

            Console.ReadKey();
        }
    }
}
