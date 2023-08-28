using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wTienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsTipo4 camisa = new clsTipo4(txtNombre.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(cboTipo.Text), Convert.ToInt32(txtIva.Text));
            clsTipo7 pantalon = new clsTipo7(txtNombre.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(cboTipo.Text), Convert.ToInt32(txtIva.Text));
            clsTipo16 camiseta = new clsTipo16(txtNombre.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(cboTipo.Text), Convert.ToInt32(txtIva.Text));



            if (cboTipo.SelectedIndex == 1)
            {
                double precioDescontado = camisa.precio1(Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtIva.Text));
                MessageBox.Show("El precio total a pagar por la camisa es: " + "" + precioDescontado);

            }

            else if (cboTipo.SelectedIndex == 2)
            {
                double precioDescontado = pantalon.precio1(Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtIva.Text));
                MessageBox.Show("El precio total a pagar por el pantalon es: " + "" + precioDescontado);

            }

            else if (cboTipo.SelectedIndex == 3)
            {
                double precioDescontado = camiseta.precio1(Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtIva.Text));
                MessageBox.Show("El precio total a pagar por la camiseta es: " + "" + precioDescontado);

            }

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cboTipo.SelectedIndex;
            int precio = 0;
            string nombre = "";
            switch (indice)
            {
                case 1:
                    precio = 45000;
                    nombre = "Camisa";
                    break;
                case 2:
                    precio = 67000;
                    nombre = "Pantalon";
                    break;
                case 3:
                    precio = 89000;
                    nombre = "Camiseta";
                    break;
            }
            txtPrecio.Text = precio.ToString();
            txtNombre.Text = nombre;
        }
    }
}
