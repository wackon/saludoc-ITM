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
    public partial class Calculadora : Form
    {
        double num1= 0, num2 =0;
        string op = "";
        string sw = "no";
        string numCadena = "";
        
        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numCadena = numCadena + "7";
            txResultado.Text = numCadena;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numCadena = numCadena + "8";
            txResultado.Text = numCadena; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numCadena = numCadena + "9";
            txResultado.Text = numCadena;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numCadena = numCadena + "4";
            txResultado.Text = numCadena;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numCadena = numCadena + "5";
            txResultado.Text = numCadena;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numCadena = numCadena + "6";
            txResultado.Text = numCadena;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numCadena = numCadena + "1";
            txResultado.Text = numCadena;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numCadena = numCadena + "2";
            txResultado.Text = numCadena;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numCadena = numCadena + "3";
            txResultado.Text = numCadena;
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            if (sw =="no"){
                numCadena = numCadena + ",";
                txResultado.Text = numCadena;
                sw = "si";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            numCadena = numCadena + "0";
            txResultado.Text = numCadena;

        }

        private void btResta_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txResultado.Text);
                txResultado.Clear();
                numCadena = "";
                op = "-";
                sw = "no";
            }
            catch
            {
                txResultado.Text = "Error";

            }
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txResultado.Text);
                txResultado.Clear();
                numCadena = "";
                op = "*";
                sw = "no";
            }
            catch
            {
                txResultado.Text = "Error";

            }
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txResultado.Text);
                txResultado.Clear();
                numCadena = "";
                op = "/";
                sw = "no";
            }
            catch
            {
                txResultado.Text = "Error";

            }
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            try {

                num2 = double.Parse(txResultado.Text);
                numCadena = "";

                switch (op)
                {
                    case "+":

                        txResultado.Text = "" + (num1 + num2);

                    break;

                    case "-":

                        txResultado.Text = "" +( num1 - num2);

                    break;

                    case "*":

                        txResultado.Text = "" + (num1 * num2);

                    break;

                    case "/":

                        txResultado.Text = "" + (num1 / num2);

                    break;
                }
            }
            catch 
            {

                txResultado.Text = "Error";
            }          
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            try {
                num1 = double.Parse(txResultado.Text);
                txResultado.Clear();
                numCadena = "";
                op = "+";
                sw = "no";
            }
            catch {
                txResultado.Text = "Error";

            }
        }
    }
}
