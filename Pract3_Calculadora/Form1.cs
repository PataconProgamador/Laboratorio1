using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pract3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSuma.CheckedChanged += new EventHandler(groupBox1_Enter);
            btnResta.CheckedChanged += new EventHandler(groupBox1_Enter);
            btnMultiplicacion.CheckedChanged += new EventHandler(groupBox1_Enter);
            btnDivision.CheckedChanged += new EventHandler(groupBox1_Enter);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            decimal operacion;
            decimal.TryParse(txtValor_1.Text, out decimal valor_1);
            decimal.TryParse(txtValor_2.Text, out decimal valor_2);
            if (btnSuma.Checked)
            {
                operacion = valor_1 + valor_2;
                txtResultado.Text = operacion.ToString();
                lblSigno.Text = "+";
            }
            else if (btnResta.Checked) 
            {
                operacion = valor_1 - valor_2;
                txtResultado.Text = operacion.ToString();
                lblSigno.Text = "-";
            }
            else if (btnMultiplicacion.Checked)
            {
                operacion = valor_1 * valor_2;
                txtResultado.Text = operacion.ToString();
                lblSigno.Text = "*";
            }
            else if (btnDivision.Checked)
            {
                if (valor_2 != 0)
                {
                    operacion = valor_1 / valor_2;
                    txtResultado.Text = operacion.ToString();
                    lblSigno.Text = "/";
                }
                else
                {
                    MessageBox.Show("Division cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblSigno_Click(object sender, EventArgs e)
        {

        }
    }
}
