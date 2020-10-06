using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saludo
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSaludo_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = txNombre.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("NO ha ingresado el nombre");
            }
            else
            {
                lbMensaje.Text = "Bienvenido a la programación Orientada a Eventos  " + nombre;
                pbImagen.Visible = true;
                btBorrar.Enabled = true;
                btSaludo.Enabled = false;
            }

        }

        private void Ventana_Load(object sender, EventArgs e)
        {

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txNombre.Clear();
            lbMensaje.Text = "";
            pbImagen.Visible = false;
            btSaludo.Enabled = true;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btcalc_Click(object sender, EventArgs e)
        {
            Calculadora objCal = new Calculadora();
            objCal.Show();
        }

        private void btregistradora_Click(object sender, EventArgs e)
        {
            Registradora objReg = new Registradora();
            objReg.Show();
        }
    }
}

