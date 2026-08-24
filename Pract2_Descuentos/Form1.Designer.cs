namespace Pract2
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
            this.lblValorVen = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblPorcDesc = new System.Windows.Forms.Label();
            this.lblVentaFinal = new System.Windows.Forms.Label();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtPorcDesc = new System.Windows.Forms.TextBox();
            this.txtVentaFinal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorVen
            // 
            this.lblValorVen.AutoSize = true;
            this.lblValorVen.Location = new System.Drawing.Point(72, 94);
            this.lblValorVen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValorVen.Name = "lblValorVen";
            this.lblValorVen.Size = new System.Drawing.Size(124, 25);
            this.lblValorVen.TabIndex = 0;
            this.lblValorVen.Text = "Valor Venta";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(72, 179);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(133, 25);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento $";
            // 
            // lblPorcDesc
            // 
            this.lblPorcDesc.AutoSize = true;
            this.lblPorcDesc.Location = new System.Drawing.Point(72, 231);
            this.lblPorcDesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPorcDesc.Name = "lblPorcDesc";
            this.lblPorcDesc.Size = new System.Drawing.Size(140, 25);
            this.lblPorcDesc.TabIndex = 2;
            this.lblPorcDesc.Text = "Descuento %";
            // 
            // lblVentaFinal
            // 
            this.lblVentaFinal.AutoSize = true;
            this.lblVentaFinal.Location = new System.Drawing.Point(72, 281);
            this.lblVentaFinal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVentaFinal.Name = "lblVentaFinal";
            this.lblVentaFinal.Size = new System.Drawing.Size(121, 25);
            this.lblVentaFinal.TabIndex = 3;
            this.lblVentaFinal.Text = "Venta Final";
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(220, 81);
            this.txtValorVenta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(196, 31);
            this.txtValorVenta.TabIndex = 4;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(220, 165);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(196, 31);
            this.txtDescuento.TabIndex = 5;
            // 
            // txtPorcDesc
            // 
            this.txtPorcDesc.Location = new System.Drawing.Point(220, 217);
            this.txtPorcDesc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPorcDesc.Name = "txtPorcDesc";
            this.txtPorcDesc.Size = new System.Drawing.Size(196, 31);
            this.txtPorcDesc.TabIndex = 6;
            // 
            // txtVentaFinal
            // 
            this.txtVentaFinal.Location = new System.Drawing.Point(220, 267);
            this.txtVentaFinal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtVentaFinal.Name = "txtVentaFinal";
            this.txtVentaFinal.Size = new System.Drawing.Size(196, 31);
            this.txtVentaFinal.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(534, 73);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 44);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(534, 129);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 44);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(534, 262);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 44);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 388);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtVentaFinal);
            this.Controls.Add(this.txtPorcDesc);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtValorVenta);
            this.Controls.Add(this.lblVentaFinal);
            this.Controls.Add(this.lblPorcDesc);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblValorVen);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorVen;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblPorcDesc;
        private System.Windows.Forms.Label lblVentaFinal;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtPorcDesc;
        private System.Windows.Forms.TextBox txtVentaFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

