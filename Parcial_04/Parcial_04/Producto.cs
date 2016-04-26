using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_04
{
    class Producto
    {
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible _tipo;

        private Producto(int codigoDeBarra)
        {
            this._codigoDeBarra = codigoDeBarra;
        }

        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo):this(codigoDeBarra)
        {
            this._nombre = nombre;
            this._tipo = tipo;
            
        }

        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo, double precio):this(codigoDeBarra, nombre, tipo)
        {
            this._precio = precio;
        }

        public void Mostrar()
        {
            
            Console.WriteLine("Nombre: " + this._nombre + "\nTipo: " + this._tipo + "\nCodigo: " + this._codigoDeBarra + "\nPrecio: " + this._precio);
        }

        public static bool operator ==(Producto unProducto, Producto otroProducto)
        {
            bool comparacion = false;

            if (unProducto._codigoDeBarra == otroProducto._codigoDeBarra)
            {
                if (unProducto._nombre==otroProducto._nombre)
                {
                    //if (unProducto._precio==otroProducto._precio)
                    //{
                        if (unProducto._tipo==otroProducto._tipo)
                        {
                            comparacion = true;
                        }                    
                    //}
                }
            }

            return comparacion;
        }

        public static bool operator !=(Producto unProducto, Producto otroProducto)
        {
            return !(unProducto == otroProducto);
        }

        public static bool operator ==(Producto unProducto, eTipoComestible tipo)
        {
            bool comparacion = false;

            if(unProducto._tipo == tipo)
            {
                comparacion = true;
            }

            return comparacion;
        }

        public static bool operator !=(Producto unProducto, eTipoComestible tipo)
        {
           return !(unProducto._tipo==tipo);
        }

    }

    public enum eTipoComestible
    {
        liquido,
        solido
    }
}
