namespace sistemasRegistrosSalario
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombreEmpleado = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_salarioB = new System.Windows.Forms.TextBox();
            this.salarioBruto = new System.Windows.Forms.Label();
            this.txt_AFP = new System.Windows.Forms.TextBox();
            this.AFP = new System.Windows.Forms.Label();
            this.porcentajeAFP = new System.Windows.Forms.Label();
            this.txt_PAFP = new System.Windows.Forms.TextBox();
            this.salarioNeto = new System.Windows.Forms.Label();
            this.txt_salarioN = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.AutoSize = true;
            this.nombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEmpleado.Location = new System.Drawing.Point(196, 36);
            this.nombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.Size = new System.Drawing.Size(68, 18);
            this.nombreEmpleado.TabIndex = 1;
            this.nombreEmpleado.Text = "Nombre";
            this.nombreEmpleado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(355, 32);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(220, 22);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_salarioB
            // 
            this.txt_salarioB.Location = new System.Drawing.Point(355, 84);
            this.txt_salarioB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_salarioB.Name = "txt_salarioB";
            this.txt_salarioB.Size = new System.Drawing.Size(220, 22);
            this.txt_salarioB.TabIndex = 3;
            // 
            // salarioBruto
            // 
            this.salarioBruto.AutoSize = true;
            this.salarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioBruto.Location = new System.Drawing.Point(157, 88);
            this.salarioBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salarioBruto.Name = "salarioBruto";
            this.salarioBruto.Size = new System.Drawing.Size(107, 18);
            this.salarioBruto.TabIndex = 4;
            this.salarioBruto.Text = "Salario Bruto";
            // 
            // txt_AFP
            // 
            this.txt_AFP.Location = new System.Drawing.Point(355, 181);
            this.txt_AFP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_AFP.Name = "txt_AFP";
            this.txt_AFP.ReadOnly = true;
            this.txt_AFP.Size = new System.Drawing.Size(220, 22);
            this.txt_AFP.TabIndex = 5;
            this.txt_AFP.Text = "salarioBruto * porcentajeAFP";
            // 
            // AFP
            // 
            this.AFP.AutoSize = true;
            this.AFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AFP.Location = new System.Drawing.Point(225, 185);
            this.AFP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AFP.Name = "AFP";
            this.AFP.Size = new System.Drawing.Size(39, 18);
            this.AFP.TabIndex = 6;
            this.AFP.Text = "AFP";
            this.AFP.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // porcentajeAFP
            // 
            this.porcentajeAFP.AutoSize = true;
            this.porcentajeAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentajeAFP.Location = new System.Drawing.Point(144, 138);
            this.porcentajeAFP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.porcentajeAFP.Name = "porcentajeAFP";
            this.porcentajeAFP.Size = new System.Drawing.Size(120, 18);
            this.porcentajeAFP.TabIndex = 7;
            this.porcentajeAFP.Text = "PorcentajeAFP";
            // 
            // txt_PAFP
            // 
            this.txt_PAFP.Location = new System.Drawing.Point(355, 134);
            this.txt_PAFP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PAFP.Name = "txt_PAFP";
            this.txt_PAFP.ReadOnly = true;
            this.txt_PAFP.Size = new System.Drawing.Size(220, 22);
            this.txt_PAFP.TabIndex = 8;
            this.txt_PAFP.Text = "0.0725";
            this.txt_PAFP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // salarioNeto
            // 
            this.salarioNeto.AutoSize = true;
            this.salarioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioNeto.Location = new System.Drawing.Point(162, 234);
            this.salarioNeto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salarioNeto.Name = "salarioNeto";
            this.salarioNeto.Size = new System.Drawing.Size(102, 18);
            this.salarioNeto.TabIndex = 9;
            this.salarioNeto.Text = "Salario Neto";
            // 
            // txt_salarioN
            // 
            this.txt_salarioN.Location = new System.Drawing.Point(355, 230);
            this.txt_salarioN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_salarioN.Name = "txt_salarioN";
            this.txt_salarioN.ReadOnly = true;
            this.txt_salarioN.Size = new System.Drawing.Size(220, 22);
            this.txt_salarioN.TabIndex = 10;
            this.txt_salarioN.Text = "SalarioBruto - AFP";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(355, 309);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(149, 43);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(355, 377);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(149, 41);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 518);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txt_salarioN);
            this.Controls.Add(this.salarioNeto);
            this.Controls.Add(this.txt_PAFP);
            this.Controls.Add(this.porcentajeAFP);
            this.Controls.Add(this.AFP);
            this.Controls.Add(this.txt_AFP);
            this.Controls.Add(this.salarioBruto);
            this.Controls.Add(this.txt_salarioB);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.nombreEmpleado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pago del Empledo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreEmpleado;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_salarioB;
        private System.Windows.Forms.Label salarioBruto;
        private System.Windows.Forms.TextBox txt_AFP;
        private System.Windows.Forms.Label AFP;
        private System.Windows.Forms.Label porcentajeAFP;
        private System.Windows.Forms.TextBox txt_PAFP;
        private System.Windows.Forms.Label salarioNeto;
        private System.Windows.Forms.TextBox txt_salarioN;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

