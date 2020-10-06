using System;
using System.Windows.Forms;

namespace Saludo
{
    public partial class Registradora : Form
    {

        double totalDiaFactura = 0;
        double totalDiaIva = 0;
        double totalDiaDescuento = 0;

        double totalFactura = 0;
        double totalIva = 0;
        double totaldescuento = 0;
        double caja = 0;


        public Registradora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txUsuario.Text))
            {
                MessageBox.Show("No ingresó el usuario");
            }
            else
            {
                if (string.IsNullOrEmpty(txClave.Text))
                {
                    MessageBox.Show("No ingresó la clave");
                }
                else
                {
                    if (txClave.Text == "1234")
                    {
                        MessageBox.Show("Bienvenido al programa " + txUsuario.Text);
                        gbFacturar.Visible = true;
                        gbLogueo.Enabled = false;
                        pbSeguridad.Visible = true;
                        caja = 50000;
                    }
                    else
                    {
                        MessageBox.Show("Clave incorrecta ");
                    }
                }

            }
        }

        private void txClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txUsuario.Clear();
            txClave.Clear();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btinicioFactura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txCliente.Text))
            {

                MessageBox.Show("No ha ingresado el Cliente");
            }
            else
            {
                if (string.IsNullOrEmpty(ltSucursal.Text))
                {
                    MessageBox.Show("No ha ingresado la Sucursal");
                }
                else

                {
                    gbFactura.Enabled = true;
                    totalFactura = 0;
                    totalIva = 0;
                    totaldescuento = 0;

                    DateTime fecha = dtFecha.Value;
                    gbFactura.Visible = true;
                    gbDatos.Enabled = false;
                    txSalida.Text = "                FACTURA DE COMPRA\r\n Nombre Cliente: " + txCliente.Text + "\t Fecha : " + fecha.Day + "/" +
                        "" + fecha.Month + "/" + fecha.Year + "\t\t Sucursal: " + ltSucursal.Text + "\r\n Producto\t\t Valor\t\t Cantidad\t IVA\t Descuento\t Subtotal";

                }

            }
        }

        private void txUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registradora_Load(object sender, EventArgs e)
        {

        }

        private void ltSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbProducto.Text)
            {
                case "TV 32":
                    txValor.Text = "500000";
                    break;


                case "TV 52":
                    txValor.Text = "1000000";
                    break;

                case "TV 80":
                    txValor.Text = "1500000";
                    break;

                case "Portatil":
                    txValor.Text = "2500000";
                    break;

                case "PC":
                    txValor.Text = "1300000";
                    break;

            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {


            txSalida.Text = txSalida.Text + "\r\n" + "Total iva " + totalIva +
            "\r\n" + "Total Descuento " + totaldescuento +
            "\r\n" + "Total a pagar " + totalFactura;
            txCliente.Clear();
            totalDiaFactura = totalDiaFactura + totalFactura; ;
            totalDiaIva = totalDiaIva + totalIva;
            totalDiaDescuento = totalDiaDescuento + totaldescuento;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double iva = 0;
            double descuento = 0; ;
            double subtotal;

            subtotal = Double.Parse(txValor.Text) * Double.Parse(txCantidad.Value.ToString());
            if (chDescuento.Checked == true)
            {
                descuento = subtotal * 10 / 100;

            }

            if (br10.Checked == true)
            {
                iva = (subtotal - descuento) * 10 / 100;
            }

            if (br19.Checked == true)
            {
                iva = (subtotal - descuento) * 19 / 100;
            }

            if (br25.Checked == true)
            {
                iva = (subtotal - descuento) * 25 / 100;
            }

            subtotal = (subtotal - descuento) + iva;


            txSalida.Text = txSalida.Text + "\r\n" + cbProducto.Text + "\t\t" + txValor.Text
                + "\t\t" + txCantidad.Value + "\t" + iva + "\t" + descuento + "\t\t" + subtotal;

            totalFactura = totalFactura + subtotal;
            totalIva = totalIva + iva;
            totaldescuento = totaldescuento + descuento;


        }

        private void btFindia_Click(object sender, EventArgs e)
        {
            caja = caja + totalDiaFactura;

            txSalida.Text = "Total Dia Factura=" + totalDiaFactura + "\r\n" +
            "Total Dia Iva =" + totalDiaIva + "\r\n" + "Total Dia Descuento =" + totalDiaDescuento + "\r\n" + "en caja hay : " + caja; ;
            gbLogueo.Enabled = true;
            gbFacturar.Enabled = false;
        }

        private void btBorrarF_Click(object sender, EventArgs e)
        {
            gbFactura.Enabled = false;
            gbDatos.Enabled = true;
            txSalida.Clear();

        }

        private void txSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txPago.Text))
            {
                MessageBox.Show("no ha ingresado el pago");
            }
            else
            {
                double canpago = 0;
                canpago = Double.Parse(txPago.Text);
                if (totalFactura <= canpago)
                {
                    txSalida.Text = txSalida.Text + "\r\n" + "la devuelta es :" + (canpago - totalFactura);
                    btNuevaF.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Cantidad insuficiente");

                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txPago.Text))
            {
                MessageBox.Show("no ha ingresado la cantida del pago");
            }
            else
            {
                double canpago = 0;
                canpago = Double.Parse(txPago.Text);
                if (totalFactura <= canpago)
                {
                    txSalida.Text = txSalida.Text + "\r\n" + "La devueta es: " +
                        (canpago - totalFactura);
                    btNuevaF.Enabled = true;
                }
                else
                {
                    MessageBox.Show("cantiadad insuficiente");
                }
            }
        }
    }
}

