using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial01
{
    class Boligrafo
    {
        private int _cantidadTinta;
        private string _color;
        private string _marca;

        public Boligrafo(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
            this._cantidadTinta = 0;
        }

        public Boligrafo(string color, string marca, int cantidadTinta)
        {
            this._color = color;
            this._marca = marca;
            this._cantidadTinta = cantidadTinta;
        }

        public Boligrafo(int cantidadTinta, string color, string marca)
        {
            this._color = color;
            this._marca = marca;
            this._cantidadTinta = cantidadTinta;
        }

        public Boligrafo(string color, int cantidadTinta, string marca)
        {
            this._color = color;
            this._marca = marca;
            this._cantidadTinta = cantidadTinta;
        }

        private void Mostrar()
        {
            Console.WriteLine("Color: "+this._color + "  Marca: "+this._marca + "  Cantidad: "+this._cantidadTinta);
        }

        public static void MostrarBoligrafos(List<Boligrafo> ListaBolifrafos)
        {
            foreach (Boligrafo item in ListaBolifrafos)
            {       
                item.Mostrar();
            }
        }

        public void Escribir(int CantidadNecesaria)
        {
            if (this._cantidadTinta < CantidadNecesaria)
            {
                Console.WriteLine("La cantidad de tinta no es suficiente");
                Mostrar();
            }
            else
            {
                this._cantidadTinta = this._cantidadTinta - CantidadNecesaria;
            }

        }

        public bool RecargarTinta()
        {
            bool recarga = false;

            if (this._cantidadTinta < 50)
            {
                this._cantidadTinta = 100;
                recarga = true;
            }

            return recarga;
        }

        public bool RecargarTinta(int cantidad)
        {
            bool recarga = false;

            if (this._cantidadTinta > 50)
            {
                this._cantidadTinta = this._cantidadTinta + cantidad;
                recarga = true;
            }

            return recarga;
        }

        public static bool operator ==(Boligrafo unPen, Boligrafo otroPen)
        {
            bool comparar = false;
            //foreach ( item in )
            //{
                if (unPen._marca == otroPen._marca && unPen._color == otroPen._color)
                {
                    comparar = true;
                    //break;
                }
            //}
            

            return comparar;
        }

        public static bool operator !=(Boligrafo unPen, Boligrafo otroPen)
        {
            return !(unPen == otroPen);
        }

        public static List<Boligrafo> operator +(List<Boligrafo> lista, Boligrafo unPen)
        {
            //List<Boligrafo> retVal = new List<Boligrafo>();
            //ESTABA CREANDO UNA LISTA NUEVA Y RETORNANDOLA, SE PERDERIAN LOS VALORES ANTERIORES
            lista.Add(unPen);

            return lista;
        }

        public static List<Boligrafo> operator -(List<Boligrafo> lista, Boligrafo unPen)
        {
            //List<Boligrafo> retVal = new List<Boligrafo>();
            foreach (Boligrafo item in lista)
            {
                if (item == unPen)
                {
                    //lista.Remove(unPen) MAL!! ESTOY REMOVIENDO unPen QUE NO ESTA EN LA LISTA
                    lista.Remove(item);
                    break;
                }
            }
            

            return lista;
        }




    }
}
