using System;
using System.Windows.Forms;

namespace practica01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double res = double.Parse(txtNumero1.Text) + double.Parse(txtNumero2.Text);

                txtResultado.Text = res.ToString();

                txtExpresion.Text = txtNumero1.Text + " + " + txtNumero2.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo se permiten números: " + "\nException: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExpresion.Clear();
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }
    }
}