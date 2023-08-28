using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wTienda
{

    /// <summary>
    /// Nombre:Viviana Muñoz Castrillon
    /// Descripcion:Se ingresa el iva del producto y al ingresar el tipo se trae tanto el nombre como el precio del mismo.
    /// </summary>
    abstract class clsArticulo
    {
        private string nombre;
        private double precio;
        private double iva;
        private int tipo;


        public clsArticulo(string nombre, double precio, double iva, int tipo)
        {
            this.Nombre = nombre;//Está asignando el valor del parámetro nombre al atributo Nombre del objeto actual (this).
            this.Precio = precio;
            this.Iva = iva;
            this.Tipo = tipo;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Iva { get => iva; set => iva = value; }
        public int Tipo { get => tipo; set => tipo = value; }

        public abstract double precio1(double descuento, double iva);




    }
}
