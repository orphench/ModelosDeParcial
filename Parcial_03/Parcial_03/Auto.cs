using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melgar.Christopher
{
    class Auto
    {
        private string _color;
        private double _precio;
        private EMarcas _marca;
        private DateTime _fecha;

        public Auto(EMarcas marca, string color)
        {
            this._marca = marca;
            this._color = color;
        }

        public Auto (EMarcas marca, string color, double precio):this(marca, color)
        {
            this._precio = precio;
        }

        public Auto (double precio, DateTime fecha)
        {
            this._precio = precio;
            this._fecha = fecha;
            //fecha.ToShortDateString();
        }

        public Auto (EMarcas marca, DateTime fecha)
        {
            this._marca = marca;
            this._fecha = fecha;
        }

        public Auto(double precio, string color, EMarcas marca)
        {
            this._precio = precio;
            this._color = color;
            this._marca = marca;
        }

        public void AgregarImpuestos(double impuesto)
        {
            this._precio = impuesto + this._precio;
        }

        public static void MostrarAuto (Auto unAuto)
        {
            Console.WriteLine("COLOR: " + unAuto._color + " PRECIO: " + unAuto._precio + " MARCA: " + unAuto._marca + " FECHA: " + unAuto._fecha);
        }

        public static bool operator ==(Auto autoUno, Auto autoDos)
        {
            bool comparacion = false;

            if(autoUno._marca == autoDos._marca)
            {
                comparacion = true;
            }

            return comparacion;
        }

        public static bool operator !=(Auto autoUno, Auto autoDos)
        {
            return !(autoUno == autoDos);
        }

        public static double operator +(Auto autoUno, Auto autoDos)
        {
            double importe = 0;

            if(autoUno==autoDos && autoUno._color==autoDos._color)
            {
                importe = autoUno._precio + autoDos._precio;
            }

            return importe;

        }
    }

    public enum EMarcas
    {
        Ford,
        Ferrari,
        Lotus
    }
}
