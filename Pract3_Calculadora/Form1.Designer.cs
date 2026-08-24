namespace Pract3
{
    partial class Form1
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
            this.btnSuma = new System.Windows.Forms.RadioButton();
            this.btnResta = new System.Windows.Forms.RadioButton();
            this.btnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.btnDivision = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtValor_1 = new System.Windows.Forms.TextBox();
            this.txtValor_2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.AutoSize = true;
            this.btnSuma.Location = new System.Drawing.Point(32, 35);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(98, 29);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.TabStop = true;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            this.btnResta.AutoSize = true;
            this.btnResta.Location = new System.Drawing.Point(32, 75);
            this.btnResta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(99, 29);
            this.btnResta.TabIndex = 1;
            this.btnResta.TabStop = true;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.AutoSize = true;
            this.btnMultiplicacion.Location = new System.Drawing.Point(32, 115);
            this.btnMultiplicacion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(174, 29);
            this.btnMultiplicacion.TabIndex = 2;
            this.btnMultiplicacion.TabStop = true;
            this.btnMultiplicacion.Text = "Multiplicación";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.AutoSize = true;
            this.btnDivision.Location = new System.Drawing.Point(32, 156);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(119, 29);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.TabStop = true;
            this.btnDivision.Text = "División";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(44, 17);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(367, 25);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Ingrese los valores y elija una opcion";
            // 
            // txtValor_1
            // 
            this.txtValor_1.Location = new System.Drawing.Point(50, 67);
            this.txtValor_1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValor_1.Name = "txtValor_1";
            this.txtValor_1.Size = new System.Drawing.Size(196, 31);
            this.txtValor_1.TabIndex = 5;
            // 
            // txtValor_2
            // 
            this.txtValor_2.Location = new System.Drawing.Point(300, 67);
            this.txtValor_2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValor_2.Name = "txtValor_2";
            this.txtValor_2.Size = new System.Drawing.Size(196, 31);
            this.txtValor_2.TabIndex = 6;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(584, 67);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(196, 31);
            this.txtResultado.TabIndex = 7;
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Location = new System.Drawing.Point(262, 70);
            this.lblSigno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(24, 25);
            this.lblSigno.TabIndex = 8;
            this.lblSigno.Text = "+";
            this.lblSigno.Click += new System.EventHandler(this.lblSigno_Click);
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(528, 73);
            this.lblIgual.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(24, 25);
            this.lblIgual.TabIndex = 9;
            this.lblIgual.Text = "=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMultiplicacion);
            this.groupBox1.Controls.Add(this.btnSuma);
            this.groupBox1.Controls.Add(this.btnResta);
            this.groupBox1.Controls.Add(this.btnDivision);
            this.groupBox1.Location = new System.Drawing.Point(50, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(400, 219);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor_2);
            this.Controls.Add(this.txtValor_1);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnSuma;
        private System.Windows.Forms.RadioButton btnResta;
        private System.Windows.Forms.RadioButton btnMultiplicacion;
        private System.Windows.Forms.RadioButton btnDivision;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtValor_1;
        private System.Windows.Forms.TextBox txtValor_2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

