using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DixonBriones3A_Trabajo3.Clases
{
    class Gasolina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private float cantidad;

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private float precio;

        public float Precio
        {
            get {
                if (tipo == "Extra")
                {
                    precio = 1.50F;
                }
                else if (tipo == "Super")
                {
                    precio = 2.00F;

                }
                return precio; }
            set { precio = value; }
        }



    }
}
