namespace TestCurp
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
            ctlCurp1 = new BibliotecaCurp.ctlCurp();
            SuspendLayout();
            // 
            // ctlCurp1
            // 
            ctlCurp1.CurpGenerada = "";
            ctlCurp1.Estado = "AS - Aguascalientes";
            ctlCurp1.FechaNacimiento = new DateTime(2025, 6, 13, 15, 49, 48, 283);
            ctlCurp1.Genero = "Masculino";
            ctlCurp1.Location = new Point(12, 10);
            ctlCurp1.Name = "ctlCurp1";
            ctlCurp1.Nombre = "";
            ctlCurp1.PrimerApellido = "";
            ctlCurp1.SegundoApellido = "";
            ctlCurp1.Size = new Size(790, 428);
            ctlCurp1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 450);
            Controls.Add(ctlCurp1);
            Name = "Form1";
            Text = "Aplicación Curp";
            ResumeLayout(false);
        }

        #endregion

        private BibliotecaCurp.ctlCurp ctlCurp1;
    }
}
