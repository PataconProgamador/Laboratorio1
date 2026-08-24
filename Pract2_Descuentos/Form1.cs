using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorVenta, descuento, porcDesc, ventaFinal;
            if(!decimal.TryParse(txtValorVenta.Text, out  valorVenta))
            {
                MessageBox.Show("Ningun Valor ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(valorVenta >= 500)
                {
                    porcDesc = 0.30m;


                } else if (valorVenta >= 300)
                {
                    porcDesc = 0.20m;

                } else if (valorVenta > 100)
                {
                    porcDesc = 0.10m;

                } else
                {
                    porcDesc = 0;
                }
                descuento = valorVenta * porcDesc;
                ventaFinal = valorVenta - descuento;
                txtDescuento.Text = descuento.ToString();
                porcDesc = porcDesc * 100;
                txtPorcDesc.Text = porcDesc.ToString() + '%';
                txtVentaFinal.Text = ventaFinal.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescuento.Text = "";
            txtPorcDesc.Text = "";
            txtValorVenta.Text = "";
            txtVentaFinal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando ventana...", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
