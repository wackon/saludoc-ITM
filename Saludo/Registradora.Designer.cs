namespace Saludo
{
    partial class Registradora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registradora));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btEnviar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.txClave = new System.Windows.Forms.TextBox();
            this.gbLogueo = new System.Windows.Forms.GroupBox();
            this.pbSeguridad = new System.Windows.Forms.PictureBox();
            this.gbFacturar = new System.Windows.Forms.GroupBox();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.btPagar = new System.Windows.Forms.Button();
            this.btBorrarF = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.txSalida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chDescuento = new System.Windows.Forms.CheckBox();
            this.br25 = new System.Windows.Forms.RadioButton();
            this.br19 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.br10 = new System.Windows.Forms.RadioButton();
            this.txCantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btFindia = new System.Windows.Forms.Button();
            this.btinicioFactura = new System.Windows.Forms.Button();
            this.ltSucursal = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbLogueo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeguridad)).BeginInit();
            this.gbFacturar.SuspendLayout();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txCantidad)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btEnviar
            // 
            this.btEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btEnviar, "btEnviar");
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btBorrar, "btBorrar");
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btSalir, "btSalir");
            this.btSalir.Name = "btSalir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // txUsuario
            // 
            resources.ApplyResources(this.txUsuario, "txUsuario");
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.TextChanged += new System.EventHandler(this.txUsuario_TextChanged);
            // 
            // txClave
            // 
            resources.ApplyResources(this.txClave, "txClave");
            this.txClave.Name = "txClave";
            this.txClave.TextChanged += new System.EventHandler(this.txClave_TextChanged);
            // 
            // gbLogueo
            // 
            this.gbLogueo.Controls.Add(this.pbSeguridad);
            this.gbLogueo.Controls.Add(this.btBorrar);
            this.gbLogueo.Controls.Add(this.txClave);
            this.gbLogueo.Controls.Add(this.label2);
            this.gbLogueo.Controls.Add(this.txUsuario);
            this.gbLogueo.Controls.Add(this.label3);
            this.gbLogueo.Controls.Add(this.btEnviar);
            resources.ApplyResources(this.gbLogueo, "gbLogueo");
            this.gbLogueo.Name = "gbLogueo";
            this.gbLogueo.TabStop = false;
            // 
            // pbSeguridad
            // 
            resources.ApplyResources(this.pbSeguridad, "pbSeguridad");
            this.pbSeguridad.Name = "pbSeguridad";
            this.pbSeguridad.TabStop = false;
            // 
            // gbFacturar
            // 
            this.gbFacturar.Controls.Add(this.gbFactura);
            this.gbFacturar.Controls.Add(this.gbDatos);
            resources.ApplyResources(this.gbFacturar, "gbFacturar");
            this.gbFacturar.Name = "gbFacturar";
            this.gbFacturar.TabStop = false;
            this.gbFacturar.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.btPagar);
            this.gbFactura.Controls.Add(this.btBorrarF);
            this.gbFactura.Controls.Add(this.btAgregar);
            this.gbFactura.Controls.Add(this.txSalida);
            this.gbFactura.Controls.Add(this.label11);
            this.gbFactura.Controls.Add(this.chDescuento);
            this.gbFactura.Controls.Add(this.br25);
            this.gbFactura.Controls.Add(this.br19);
            this.gbFactura.Controls.Add(this.label10);
            this.gbFactura.Controls.Add(this.br10);
            this.gbFactura.Controls.Add(this.txCantidad);
            this.gbFactura.Controls.Add(this.label9);
            this.gbFactura.Controls.Add(this.txValor);
            this.gbFactura.Controls.Add(this.label8);
            this.gbFactura.Controls.Add(this.cbProducto);
            this.gbFactura.Controls.Add(this.label7);
            resources.ApplyResources(this.gbFactura, "gbFactura");
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.TabStop = false;
            // 
            // btPagar
            // 
            resources.ApplyResources(this.btPagar, "btPagar");
            this.btPagar.Name = "btPagar";
            this.btPagar.UseVisualStyleBackColor = true;
            this.btPagar.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btBorrarF
            // 
            resources.ApplyResources(this.btBorrarF, "btBorrarF");
            this.btBorrarF.Name = "btBorrarF";
            this.btBorrarF.UseVisualStyleBackColor = true;
            this.btBorrarF.Click += new System.EventHandler(this.btBorrarF_Click);
            // 
            // btAgregar
            // 
            resources.ApplyResources(this.btAgregar, "btAgregar");
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txSalida
            // 
            resources.ApplyResources(this.txSalida, "txSalida");
            this.txSalida.Name = "txSalida";
            this.txSalida.TextChanged += new System.EventHandler(this.txSalida_TextChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Name = "label11";
            // 
            // chDescuento
            // 
            resources.ApplyResources(this.chDescuento, "chDescuento");
            this.chDescuento.Name = "chDescuento";
            this.chDescuento.UseVisualStyleBackColor = true;
            // 
            // br25
            // 
            resources.ApplyResources(this.br25, "br25");
            this.br25.Name = "br25";
            this.br25.UseVisualStyleBackColor = true;
            this.br25.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // br19
            // 
            resources.ApplyResources(this.br19, "br19");
            this.br19.Checked = true;
            this.br19.Name = "br19";
            this.br19.TabStop = true;
            this.br19.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // br10
            // 
            resources.ApplyResources(this.br10, "br10");
            this.br10.Name = "br10";
            this.br10.UseVisualStyleBackColor = true;
            // 
            // txCantidad
            // 
            resources.ApplyResources(this.txCantidad, "txCantidad");
            this.txCantidad.Name = "txCantidad";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txValor
            // 
            resources.ApplyResources(this.txValor, "txValor");
            this.txValor.Name = "txValor";
            this.txValor.ReadOnly = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Items.AddRange(new object[] {
            resources.GetString("cbProducto.Items"),
            resources.GetString("cbProducto.Items1"),
            resources.GetString("cbProducto.Items2"),
            resources.GetString("cbProducto.Items3"),
            resources.GetString("cbProducto.Items4")});
            resources.ApplyResources(this.cbProducto, "cbProducto");
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            this.cbProducto.SelectedValueChanged += new System.EventHandler(this.cbProducto_SelectedValueChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDatos.Controls.Add(this.btFindia);
            this.gbDatos.Controls.Add(this.btinicioFactura);
            this.gbDatos.Controls.Add(this.ltSucursal);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.dtFecha);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.txCliente);
            this.gbDatos.Controls.Add(this.label4);
            resources.ApplyResources(this.gbDatos, "gbDatos");
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.TabStop = false;
            this.gbDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btFindia
            // 
            resources.ApplyResources(this.btFindia, "btFindia");
            this.btFindia.Name = "btFindia";
            this.btFindia.UseVisualStyleBackColor = true;
            this.btFindia.Click += new System.EventHandler(this.btFindia_Click);
            // 
            // btinicioFactura
            // 
            this.btinicioFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btinicioFactura, "btinicioFactura");
            this.btinicioFactura.Name = "btinicioFactura";
            this.btinicioFactura.UseVisualStyleBackColor = true;
            this.btinicioFactura.Click += new System.EventHandler(this.btinicioFactura_Click);
            // 
            // ltSucursal
            // 
            this.ltSucursal.BackColor = System.Drawing.SystemColors.Window;
            this.ltSucursal.FormattingEnabled = true;
            resources.ApplyResources(this.ltSucursal, "ltSucursal");
            this.ltSucursal.Items.AddRange(new object[] {
            resources.GetString("ltSucursal.Items"),
            resources.GetString("ltSucursal.Items1"),
            resources.GetString("ltSucursal.Items2"),
            resources.GetString("ltSucursal.Items3")});
            this.ltSucursal.Name = "ltSucursal";
            this.ltSucursal.SelectedIndexChanged += new System.EventHandler(this.ltSucursal_SelectedIndexChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtFecha
            // 
            resources.ApplyResources(this.dtFecha, "dtFecha");
            this.dtFecha.Name = "dtFecha";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txCliente
            // 
            resources.ApplyResources(this.txCliente, "txCliente");
            this.txCliente.Name = "txCliente";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Registradora
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gbFacturar);
            this.Controls.Add(this.gbLogueo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalir);
            this.Name = "Registradora";
            this.Load += new System.EventHandler(this.Registradora_Load);
            this.gbLogueo.ResumeLayout(false);
            this.gbLogueo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeguridad)).EndInit();
            this.gbFacturar.ResumeLayout(false);
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txCantidad)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.TextBox txClave;
        private System.Windows.Forms.GroupBox gbLogueo;
        private System.Windows.Forms.GroupBox gbFacturar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btinicioFactura;
        private System.Windows.Forms.ListBox ltSucursal;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.RadioButton br25;
        private System.Windows.Forms.RadioButton br19;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton br10;
        private System.Windows.Forms.NumericUpDown txCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txSalida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chDescuento;
        private System.Windows.Forms.PictureBox pbSeguridad;
        private System.Windows.Forms.Button btPagar;
        private System.Windows.Forms.Button btBorrarF;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btFindia;
    }
}