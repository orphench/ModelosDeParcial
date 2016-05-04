using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_07
{
    class Fabrica
    {
        private Operario[] _operarios;
        private string _razonSocial;

        public Fabrica()
        {
            this._operarios = new Operario[5];
        }

        public Fabrica(string razonSocial):this()
        {
            this._razonSocial = razonSocial;
        }

        private float RetornarCostos()
        {
            float costoTotal = 0f;

            for (int i = 0; i < this._operarios.Length; i++)
            {
                costoTotal = costoTotal + this._operarios[i].getSalario();
            }

            return costoTotal;
        }

        private int ObtenerIndice()
        {
            for (int i = 0; i < this._operarios.Length; i++)
            {
                if (this._operarios.GetValue(i) == null)
                {
                    return i;
                }              
            }

            return -1;
        }

        private int ObtenerIndice(Operario ope)
        {
            for (int i = 0; i < this._operarios.Length; i++)
            {
                if ((object)this._operarios.GetValue(i) == ope)
                {
                    return i;
                }
            }

            return -1;
        }

        private string MostrarOperarios()
        {
            string todosLosOperarios = null;

            for (int i = 0; i < this._operarios.Length; i++)
            {              
                    todosLosOperarios = todosLosOperarios + this._operarios[i].Mostrar();                  

            }

            return todosLosOperarios;
        }

        public static void MostrarCosto(Fabrica fbr)
        {
            Console.WriteLine("\n{0:C2}",fbr.RetornarCostos());
        }

        public string Mostrar()
        {           
            return "\nRazon Social: " + this._razonSocial + "\n\nOPERARIOS:\n" + MostrarOperarios();
        }

        public static bool operator ==(Fabrica fbr, Operario op)
        {
            bool SeEncuentra = false;

            //for (int i = 0; i < fbr._operarios.Length; i++)
            //{
            //    if ((object)fbr._operarios.GetValue(i) == op)
            //    {
            //        SeEncuentra = true;
            //        break;
            //    }
            //}

            foreach (Operario item in fbr._operarios)
            {
                if ((object)item != null && item == op)
                {
                    SeEncuentra = true;
                    break;
                }
            }

            return SeEncuentra;
        }

        public static bool operator !=(Fabrica fbr, Operario op)
        {
            return !(fbr == op);
        }

        public static Fabrica operator +(Fabrica fbr, Operario op)
        {
            if (fbr.ObtenerIndice()==-1)
            {
                Console.WriteLine("La Fabrica esta Full");
            }
            else
            {
                if (fbr == op)
                {
                    Console.WriteLine("El Operario ya esta en la fabrica");
                }
                else
                {
                    fbr._operarios[fbr.ObtenerIndice()] = op;
                }
            }

            return fbr;
        }

        public static Fabrica operator -(Fabrica fbr, Operario op)
        {
            //if (fbr.ObtenerIndice() != -1)
            //{
                if (fbr == op)
                {
                    fbr._operarios[fbr.ObtenerIndice(op)] = null;
                }
                else
                {
                    Console.WriteLine("No se encontro al empleado!!!");
                }
            //}
            
            return fbr;     
        }
    }
}
