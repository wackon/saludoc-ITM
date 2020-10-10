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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            String nom = "";
            int pos = 0;

            nom = txNombre.Text;
            pos =Ppal.objBanco.buscar(nom);
            if (pos >= 0)
            {
                int clave = 0;
                clave = Int32.Parse(txClave.Text);
                if (clave == Ppal.objBanco.VecClientes()[pos].getNumero()) {   
                txCodigo.Text = ""+Ppal.objBanco.VecClientes()[pos].getNumero(); 
                txSaldo.Text = ""+Ppal.objBanco.VecClientes()[pos].decirSaldo();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta/n"); }
            }

        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
