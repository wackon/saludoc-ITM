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
    public partial class Ppal : Form

        
    {
        public static Banco objBanco;


        public Ppal()
        {
            InitializeComponent();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccion copiar");
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccion pegar");
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccion cortar");
        }

        private void saludarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana objVent = new Ventana();
            
            objVent.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora objCalc = new Calculadora();
            objCalc.MdiParent = this;
            objCalc.Show();
        }

        private void registradoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registradora objReg = new Registradora();
            objReg.MdiParent = this;
            objReg.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripSaludo_Click(object sender, EventArgs e)
        {
            Ventana objVent = new Ventana();
            objVent.Show();

        }

        private void toolStripAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aparece las ayudas");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Web objweb = new Web();
            objweb.Show();
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void existentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objBanco = new Banco();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consulta objCon = new Consulta();
            objCon.MdiParent = this;
            objCon.Show();

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void retiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Retiro objRet = new Retiro();
            objRet.MdiParent = this;
            objRet.Show();
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
