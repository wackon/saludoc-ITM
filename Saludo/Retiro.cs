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


    public partial class Retiro : Form


    {
        int pos = -1;
        public Retiro()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            String nom = "";


            nom = txNombre.Text;
            pos = Ppal.objBanco.buscar(nom);
            if (pos >= 0)
            {
                int clave = 0;
                clave = Int32.Parse(txClave.Text);
                if (clave == Ppal.objBanco.VecClientes()[pos].getNumero())
                {
                    gbDatos.Visible = true;
                    btRetirar.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Clave incorrecta/n");
                }
            }
        }


            private void btRetirar_Click(object sender, EventArgs e)
            {
                double cant = 0;
                cant = Double.Parse(txCantidad.Text);
                Ppal.objBanco.VecClientes()[pos].retiro(cant);
                txSaldo.Text = "" + Ppal.objBanco.VecClientes()[pos].decirSaldo();
            }
        }
    }

