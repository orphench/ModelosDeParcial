using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melgar.Christopher;

namespace Parcial_03
{
    class Garage
    {
        private string _razonSocial;
        private double _precioPorHora;
        private Auto[] autos;

        private Garage()
        {

        }

        public Garage(string razonSocial, double precioPorHora)
        {
            this._razonSocial = razonSocial;
            this._precioPorHora = precioPorHora;
            this.autos = new Auto[5];
        }

        public Garage(double precioPorHora, string razonSocial)
        {
            this._precioPorHora = precioPorHora;
            this._razonSocial = razonSocial;
            this.autos = new Auto[5];
        }

        public Garage(string razonSocial)
        {
            this._razonSocial = razonSocial;
            this.autos = new Auto[5];
        }

        public Garage(double precioPorHora)
        {
            this._precioPorHora = precioPorHora;
            this.autos = new Auto[5];
        }

        public void MostrarGarage()
        {
            Console.WriteLine(this._razonSocial + this._precioPorHora + this.autos);
        }

        public static bool operator ==(Garage unGaraje, Auto unAuto)
        {
            bool respuesta = false;

            foreach (Auto item in unGaraje.autos)
            {
                if ((object)item != null && item == unAuto)
                {
                    respuesta = true;
                    break;
                }
            }

            return respuesta;
        }

        public static bool operator !=(Garage unGaraje, Auto unAuto)
        {
            return !(unGaraje == unAuto);
        }

    }
}
