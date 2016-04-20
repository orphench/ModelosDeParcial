using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroNamespace
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

        public Boligrafo(int cantidadTinta, string marca, string color)
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

        public void Mostrar()
        {
            Console.WriteLine(_color + _marca + _cantidadTinta);
        }
    }
}
