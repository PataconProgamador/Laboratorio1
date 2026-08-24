namespace Pracr1_controles
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.txt_3 = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(45, 35);
            this.lbl_1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(44, 25);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Día";
            this.lbl_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(185, 35);
            this.txt_1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(196, 31);
            this.txt_1.TabIndex = 1;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(45, 112);
            this.lbl_2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(53, 25);
            this.lbl_2.TabIndex = 2;
            this.lbl_2.Text = "Mes";
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(185, 99);
            this.txt_2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(196, 31);
            this.txt_2.TabIndex = 3;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(45, 189);
            this.lbl_3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(50, 25);
            this.lbl_3.TabIndex = 4;
            this.lbl_3.Text = "Año";
            // 
            // txt_3
            // 
            this.txt_3.Location = new System.Drawing.Point(185, 174);
            this.txt_3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_3.Name = "txt_3";
            this.txt_3.Size = new System.Drawing.Size(196, 31);
            this.txt_3.TabIndex = 5;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(71, 283);
            this.btn_1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(150, 44);
            this.btn_1.TabIndex = 6;
            this.btn_1.Text = "Enviar";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(299, 283);
            this.btn_2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(150, 44);
            this.btn_2.TabIndex = 7;
            this.btn_2.Text = "Cerrar";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Location = new System.Drawing.Point(532, 105);
            this.lbl_4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(130, 25);
            this.lbl_4.TabIndex = 8;
            this.lbl_4.Text = "La fecha es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 372);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txt_3);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.lbl_1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.TextBox txt_3;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Label lbl_4;
    }
}

