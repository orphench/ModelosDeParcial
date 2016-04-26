using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_04
{
    class Container
    {
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;

        public Container(int capacidad, string empresa)
        {
            this._capacidad = capacidad;
            this._empresa = empresa;
            this._listaProductos = new List<Producto>();
        }

        public static void Mostrar(Container contenerdor)
        {
            Console.WriteLine("—__—__Container__—__—");
            Console.WriteLine("Empresa: " + contenerdor._empresa + "\nCapacidad: " + contenerdor._capacidad+"\nProductos:");

            foreach (Producto item in contenerdor._listaProductos)
            {
                item.Mostrar();
            }
        }

        public static bool operator ==(Container contenerdor, Producto otroProducto)
        {
            bool comparacion = false;

            foreach (Producto item in contenerdor._listaProductos)
            {
                if (item == otroProducto)
                {
                    comparacion = true;
                }
            }

            return comparacion;
        }

        public static bool operator !=(Container contenedor, Producto otroProducto)
        {
            return !(contenedor == otroProducto);
        }

        public bool Agregar(Producto unProducto)
        {
            bool agregado = false;

            if (this._capacidad > _listaProductos.Count)
           {
                if(this!=unProducto)
                {
                    this._listaProductos.Add(unProducto);
                    agregado = true;
                }             
           }
            
            return agregado;
        }

        public static List<Producto> operator -(Container contenedorUno, eTipoComestible tipo)
        {
            List<Producto> Lista = new List<Producto>();

            foreach (Producto item in contenedorUno._listaProductos)
            {
                if (item==tipo)
                {
                    Lista.Add(item);             
                }
            }

            return Lista;
        }
            
    }
}
