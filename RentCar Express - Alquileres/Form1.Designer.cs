namespace RentCar_Express___Alquileres
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Dias = new Label();
            checkCorporativo = new CheckBox();
            chkGps = new CheckBox();
            groupBox1 = new GroupBox();
            rbtCompleto = new RadioButton();
            rbtBasico = new RadioButton();
            Entrega = new GroupBox();
            rbtDomicilio = new RadioButton();
            tbrSucursal = new RadioButton();
            btnAgregar = new Button();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label6 = new Label();
            label7 = new Label();
            Descuento = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            IbIEncabezado = new Label();
            IstAlquileres = new ListBox();
            nudDias = new NumericUpDown();
            txtCliente = new TextBox();
            dtpsalida = new TextBox();
            txtTarifa = new TextBox();
            txtVehiculo = new DateTimePicker();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            groupBox1.SuspendLayout();
            Entrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 29);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 115);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Salida:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 191);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Vehiculo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 264);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Tarifa:";
            // 
            // Dias
            // 
            Dias.AutoSize = true;
            Dias.Location = new Point(50, 327);
            Dias.Name = "Dias";
            Dias.Size = new Size(41, 20);
            Dias.TabIndex = 4;
            Dias.Text = "Dias:";
            // 
            // checkCorporativo
            // 
            checkCorporativo.AutoSize = true;
            checkCorporativo.Checked = true;
            checkCorporativo.CheckState = CheckState.Checked;
            checkCorporativo.Location = new Point(50, 65);
            checkCorporativo.Name = "checkCorporativo";
            checkCorporativo.Size = new Size(160, 24);
            checkCorporativo.TabIndex = 5;
            checkCorporativo.Text = "Cliente Corporativo";
            checkCorporativo.UseVisualStyleBackColor = true;
            checkCorporativo.CheckedChanged += checkCorporativo_CheckedChanged;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(77, 596);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(177, 24);
            chkGps.TabIndex = 6;
            chkGps.Text = "GPS (+RD100 por dia)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtCompleto);
            groupBox1.Controls.Add(rbtBasico);
            groupBox1.Location = new Point(50, 465);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seguro";
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.Checked = true;
            rbtCompleto.Location = new Point(16, 77);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(172, 24);
            rbtCompleto.TabIndex = 24;
            rbtCompleto.TabStop = true;
            rbtCompleto.Text = "Completo (+RD$300)";
            rbtCompleto.UseVisualStyleBackColor = true;
            rbtCompleto.CheckedChanged += rbtCompleto_CheckedChanged;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.Location = new Point(27, 38);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(73, 24);
            rbtBasico.TabIndex = 23;
            rbtBasico.Text = "Basico";
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // Entrega
            // 
            Entrega.Controls.Add(rbtDomicilio);
            Entrega.Controls.Add(tbrSucursal);
            Entrega.Location = new Point(396, 465);
            Entrega.Name = "Entrega";
            Entrega.Size = new Size(250, 125);
            Entrega.TabIndex = 8;
            Entrega.TabStop = false;
            Entrega.Text = "Entrega";
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Checked = true;
            rbtDomicilio.Location = new Point(19, 77);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(175, 24);
            rbtDomicilio.TabIndex = 25;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = " Domicilio (+RD$500)";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // tbrSucursal
            // 
            tbrSucursal.AutoSize = true;
            tbrSucursal.Location = new Point(19, 38);
            tbrSucursal.Name = "tbrSucursal";
            tbrSucursal.Size = new Size(102, 24);
            tbrSucursal.TabIndex = 26;
            tbrSucursal.Text = "En sucursal";
            tbrSucursal.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(551, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(203, 63);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar al alquiler";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(66, 644);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(203, 63);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(396, 644);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(203, 63);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Nuevo Alquiler";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(670, 644);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(203, 63);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(727, 485);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 13;
            label6.Text = "Domicilio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1007, 402);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 14;
            label7.Text = "IbIDescuento";
            // 
            // Descuento
            // 
            Descuento.AutoSize = true;
            Descuento.Location = new Point(727, 402);
            Descuento.Name = "Descuento";
            Descuento.Size = new Size(79, 20);
            Descuento.TabIndex = 15;
            Descuento.Text = "Descuento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1007, 339);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 16;
            label9.Text = "IbISubtotal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(727, 339);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 17;
            label10.Text = "SubTotal";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(692, 595);
            label11.Name = "label11";
            label11.Size = new Size(114, 20);
            label11.TabIndex = 18;
            label11.Text = "TOTAL A PAGAR";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1007, 539);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 19;
            label12.Text = "IbIItbis";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(727, 546);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 20;
            label13.Text = "ITBIS (18$)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1007, 485);
            label14.Name = "label14";
            label14.Size = new Size(96, 20);
            label14.TabIndex = 1;
            label14.Text = "IbIDescuento";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1007, 595);
            label15.Name = "label15";
            label15.Size = new Size(55, 20);
            label15.TabIndex = 21;
            label15.Text = "IbTotal";
            // 
            // IbIEncabezado
            // 
            IbIEncabezado.AutoSize = true;
            IbIEncabezado.Location = new Point(539, 122);
            IbIEncabezado.Name = "IbIEncabezado";
            IbIEncabezado.Size = new Size(107, 20);
            IbIEncabezado.TabIndex = 22;
            IbIEncabezado.Text = "IbIEncabezado";
            // 
            // IstAlquileres
            // 
            IstAlquileres.FormattingEnabled = true;
            IstAlquileres.Location = new Point(539, 180);
            IstAlquileres.Name = "IstAlquileres";
            IstAlquileres.Size = new Size(233, 104);
            IstAlquileres.TabIndex = 23;
            IstAlquileres.SelectedIndexChanged += IstAlquileres_SelectedIndexChanged;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(169, 332);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(150, 27);
            nudDias.TabIndex = 24;
            nudDias.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(160, 29);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(168, 27);
            txtCliente.TabIndex = 25;
            // 
            // dtpsalida
            // 
            dtpsalida.Location = new Point(151, 115);
            dtpsalida.Name = "dtpsalida";
            dtpsalida.Size = new Size(168, 27);
            dtpsalida.TabIndex = 26;
            dtpsalida.TextChanged += textBox2_TextChanged;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(169, 264);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(168, 27);
            txtTarifa.TabIndex = 27;
            txtTarifa.TextChanged += txtTarifa_TextChanged;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(151, 191);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(250, 27);
            txtVehiculo.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(812, 339);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(168, 27);
            textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(802, 402);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(168, 27);
            textBox5.TabIndex = 30;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(812, 478);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(168, 27);
            textBox6.TabIndex = 31;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(812, 592);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(168, 27);
            textBox7.TabIndex = 32;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(812, 539);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(168, 27);
            textBox8.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1191, 728);
            Controls.Add(btnAgregar);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(txtVehiculo);
            Controls.Add(txtTarifa);
            Controls.Add(dtpsalida);
            Controls.Add(txtCliente);
            Controls.Add(nudDias);
            Controls.Add(IstAlquileres);
            Controls.Add(IbIEncabezado);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(Descuento);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(Entrega);
            Controls.Add(groupBox1);
            Controls.Add(chkGps);
            Controls.Add(checkCorporativo);
            Controls.Add(Dias);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            Text = "nudDias";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Entrega.ResumeLayout(false);
            Entrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Dias;
        private CheckBox checkCorporativo;
        private CheckBox chkGps;
        private GroupBox groupBox1;
        private GroupBox Entrega;
        private Label label14;
        private Button btnAgregar;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label6;
        private Label label7;
        private Label Descuento;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private RadioButton rbtCompleto;
        private RadioButton rbtBasico;
        private RadioButton rbtDomicilio;
        private RadioButton tbrSucursal;
        private Label label15;
        private Label IbIEncabezado;
        private ListBox IstAlquileres;
        private NumericUpDown nudDias;
        private TextBox txtCliente;
        private TextBox dtpsalida;
        private TextBox txtTarifa;
        private DateTimePicker txtVehiculo;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}
