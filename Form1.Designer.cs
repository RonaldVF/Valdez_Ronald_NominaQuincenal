namespace WinFormsApp1
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
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rdbTemporal = new RadioButton();
            rdbFijo = new RadioButton();
            txtEmpleado = new TextBox();
            groupBox2 = new GroupBox();
            lblDeducciones = new Label();
            lblNeto = new Label();
            lblBruto = new Label();
            lblEmpleados = new Label();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnRegistrar = new Button();
            chkTransporte = new CheckBox();
            txtHoras = new TextBox();
            cmbCargo = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            groupBox4 = new GroupBox();
            lstNomina = new ListBox();
            btnResumen = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 92);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Contrato:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbTemporal);
            groupBox1.Controls.Add(rdbFijo);
            groupBox1.Controls.Add(txtEmpleado);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 145);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del empleado";
            // 
            // rdbTemporal
            // 
            rdbTemporal.AutoSize = true;
            rdbTemporal.Location = new Point(224, 92);
            rdbTemporal.Name = "rdbTemporal";
            rdbTemporal.Size = new Size(93, 24);
            rdbTemporal.TabIndex = 5;
            rdbTemporal.TabStop = true;
            rdbTemporal.Text = "Temporal";
            rdbTemporal.UseVisualStyleBackColor = true;
            // 
            // rdbFijo
            // 
            rdbFijo.AutoSize = true;
            rdbFijo.Location = new Point(122, 92);
            rdbFijo.Name = "rdbFijo";
            rdbFijo.Size = new Size(54, 24);
            rdbFijo.TabIndex = 4;
            rdbFijo.TabStop = true;
            rdbFijo.Text = "Fijo";
            rdbFijo.UseVisualStyleBackColor = true;
            // 
            // txtEmpleado
            // 
            txtEmpleado.ForeColor = SystemColors.ActiveCaptionText;
            txtEmpleado.Location = new Point(100, 46);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(276, 27);
            txtEmpleado.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblDeducciones);
            groupBox2.Controls.Add(lblNeto);
            groupBox2.Controls.Add(lblBruto);
            groupBox2.Controls.Add(lblEmpleados);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(449, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(311, 230);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resumen";
            // 
            // lblDeducciones
            // 
            lblDeducciones.AutoSize = true;
            lblDeducciones.Location = new Point(191, 127);
            lblDeducciones.Name = "lblDeducciones";
            lblDeducciones.Size = new Size(21, 20);
            lblDeducciones.TabIndex = 8;
            lblDeducciones.Text = "--";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(191, 173);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(21, 20);
            lblNeto.TabIndex = 7;
            lblNeto.Text = "--";
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(191, 82);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(21, 20);
            lblBruto.TabIndex = 6;
            lblBruto.Text = "--";
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Location = new Point(191, 37);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(21, 20);
            lblEmpleados.TabIndex = 5;
            lblEmpleados.Text = "--";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 173);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 4;
            label8.Text = "Total neto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 127);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 3;
            label7.Text = "Total deducciones:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 37);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 1;
            label1.Text = "Empleado registrado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 82);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 2;
            label4.Text = "Total bruto:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRegistrar);
            groupBox3.Controls.Add(chkTransporte);
            groupBox3.Controls.Add(txtHoras);
            groupBox3.Controls.Add(cmbCargo);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(22, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(407, 298);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Registro de pago";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(96, 242);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(221, 41);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar Empleados";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // chkTransporte
            // 
            chkTransporte.AutoSize = true;
            chkTransporte.Location = new Point(19, 175);
            chkTransporte.Name = "chkTransporte";
            chkTransporte.Size = new Size(233, 24);
            chkTransporte.TabIndex = 5;
            chkTransporte.Text = "Recibe incentivo de transporte";
            chkTransporte.UseVisualStyleBackColor = true;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(15, 115);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(97, 27);
            txtHoras.TabIndex = 4;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(86, 30);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(231, 28);
            cmbCargo.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 33);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 1;
            label5.Text = "Cargo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 80);
            label6.Name = "label6";
            label6.Size = new Size(225, 20);
            label6.TabIndex = 2;
            label6.Text = "Horas trabajadas en la quincena:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstNomina);
            groupBox4.Location = new Point(449, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(311, 213);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Nomina registrada";
            // 
            // lstNomina
            // 
            lstNomina.FormattingEnabled = true;
            lstNomina.Location = new Point(6, 26);
            lstNomina.Name = "lstNomina";
            lstNomina.Size = new Size(299, 164);
            lstNomina.TabIndex = 0;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(85, 467);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(192, 44);
            btnResumen.TabIndex = 5;
            btnResumen.Text = "Mostrar resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(356, 467);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(153, 40);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(583, 467);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 40);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 519);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnResumen);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nomina Quincenal";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private Label label6;
        private GroupBox groupBox4;
        private ListBox lstNomina;
        private Button btnResumen;
        private Button btnLimpiar;
        private Button btnSalir;
        private RadioButton rdbTemporal;
        private RadioButton rdbFijo;
        private TextBox txtEmpleado;
        private Label lblEmpleados;
        private Label label8;
        private Label label7;
        private Label lblDeducciones;
        private Label lblNeto;
        private Label lblBruto;
        private Button btnRegistrar;
        private CheckBox chkTransporte;
        private TextBox txtHoras;
        private ComboBox cmbCargo;
    }
}
