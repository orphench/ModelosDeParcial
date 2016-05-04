using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_07
{
    class Operario
    {
        private string _apellido;
        private string _nombre;
        private int _legajo;
        private float _salario;

        public Operario()
        {
            this._salario = 1500f;
        }

        public Operario(string nombre, string apellido):this()
        {
            this._nombre = nombre;
            this._apellido = apellido;       
        }

        public Operario(string nombre, string apellido, int legajo):this(nombre, apellido)
        {
            this._legajo = legajo;
        }


        public float getSalario()
        {
            return this._salario;
        }

        public void setAumentarSalario(float aumento)
        {
            this._salario = this._salario + (this._salario / (100 / aumento));
        }

        public string ObtenerNombreYApellido()
        {
            return "\nNombre y Apellido: " + this._nombre + ", " + this._apellido;
        }

        public string Mostrar()
        {
            return this.ObtenerNombreYApellido() + "\nLegajo: " + this._legajo + "\nSalario:" + this._salario;
        }

        public static string Mostrar(Operario ope)
        {
            return ope.Mostrar();
        }

        public static bool operator ==(Operario op1, Operario op2)
        {
            bool comparacion = false;

            if (op1.ObtenerNombreYApellido() == op2.ObtenerNombreYApellido())
            {
                if (op1._legajo == op2._legajo)
                {
                    comparacion = true;
                }
            }

            return comparacion;
        }

        public static bool operator !=(Operario op1, Operario op2)
        {
            return !(op1 == op2);
        }
    }
}
