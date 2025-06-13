namespace BibliotecaCurp
{
    partial class ctlCurp
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrimerApellido = new TextBox();
            label4 = new Label();
            txtSegundoApellido = new TextBox();
            dtpFechaNac = new DateTimePicker();
            label5 = new Label();
            cboSexo = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cboEstado = new ComboBox();
            label8 = new Label();
            lblCurpGenerada = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 24);
            label1.Name = "label1";
            label1.Size = new Size(234, 31);
            label1.TabIndex = 0;
            label1.Text = "Generación de Curp";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(21, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ej Ricardo";
            txtNombre.Size = new Size(234, 30);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(21, 78);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "Nombre(s):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(288, 78);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 7;
            label3.Text = "Apellido Paterno:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimerApellido.Location = new Point(288, 104);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.PlaceholderText = "Ej Moreno";
            txtPrimerApellido.Size = new Size(234, 30);
            txtPrimerApellido.TabIndex = 6;
            txtPrimerApellido.TextChanged += txtPrimerApellido_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(551, 78);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 9;
            label4.Text = "Apellido Materno:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundoApellido.Location = new Point(551, 104);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.PlaceholderText = "Ej Moreno";
            txtSegundoApellido.Size = new Size(234, 30);
            txtSegundoApellido.TabIndex = 8;
            txtSegundoApellido.TextChanged += txtSegundoApellido_TextChanged;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(21, 203);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(234, 30);
            dtpFechaNac.TabIndex = 10;
            dtpFechaNac.ValueChanged += dtpFechaNac_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(21, 177);
            label5.Name = "label5";
            label5.Size = new Size(182, 23);
            label5.TabIndex = 11;
            label5.Text = "Fecha de Nacimiento:";
            // 
            // cboSexo
            // 
            cboSexo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cboSexo.Location = new Point(288, 202);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(234, 31);
            cboSexo.TabIndex = 12;
            cboSexo.SelectedIndexChanged += cboSexo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(288, 177);
            label6.Name = "label6";
            label6.Size = new Size(53, 23);
            label6.TabIndex = 13;
            label6.Text = "Sexo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(551, 177);
            label7.Name = "label7";
            label7.Size = new Size(166, 23);
            label7.TabIndex = 15;
            label7.Text = "Entidad Federativa:";
            // 
            // cboEstado
            // 
            cboEstado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(551, 202);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(234, 31);
            cboEstado.TabIndex = 14;
            cboEstado.SelectedIndexChanged += cboEstado_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 274);
            label8.Name = "label8";
            label8.Size = new Size(136, 31);
            label8.TabIndex = 16;
            label8.Text = "Tu curp es:";
            // 
            // lblCurpGenerada
            // 
            lblCurpGenerada.AutoSize = true;
            lblCurpGenerada.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurpGenerada.ForeColor = Color.FromArgb(0, 123, 0);
            lblCurpGenerada.Location = new Point(157, 274);
            lblCurpGenerada.Name = "lblCurpGenerada";
            lblCurpGenerada.Size = new Size(285, 31);
            lblCurpGenerada.TabIndex = 17;
            lblCurpGenerada.Text = "MOSR050311HGTRLCA0";
            // 
            // ctlCurp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCurpGenerada);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cboEstado);
            Controls.Add(label6);
            Controls.Add(cboSexo);
            Controls.Add(label5);
            Controls.Add(dtpFechaNac);
            Controls.Add(label4);
            Controls.Add(txtSegundoApellido);
            Controls.Add(label3);
            Controls.Add(txtPrimerApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "ctlCurp";
            Size = new Size(800, 342);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private TextBox txtPrimerApellido;
        private Label label4;
        private TextBox txtSegundoApellido;
        private DateTimePicker dtpFechaNac;
        private Label label5;
        private ComboBox cboSexo;
        private Label label6;
        private Label label7;
        private ComboBox cboEstado;
        private Label label8;
        private Label lblCurpGenerada;
    }
}
