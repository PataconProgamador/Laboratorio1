using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracr1_controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_1.Text) || string.IsNullOrWhiteSpace(txt_2.Text) || string.IsNullOrWhiteSpace(txt_3.Text))
            {
                MessageBox.Show("Campos no rellenos cerrando ventana.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                lbl_4.Text = "La fecha es:" + txt_1.Text + "/" + txt_2.Text + "/" + txt_3.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cerrando ventana.", "Cerrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
