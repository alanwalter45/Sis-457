using System;
using System.Windows.Forms;

namespace grupo_01
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

                if (txtNombreCompleto.Text.Length > 0 && txtHorasTrabajadas.Value>0 && txtTarifa.Value>0)
                {
                    Trabajador t = new Trabajador()
                    {
                        NombreCompleto = txtNombreCompleto.Text,
                        HorasTrabajadas = (float)txtHorasTrabajadas.Value,
                        TarifaPorHora = (float)txtTarifa.Value
                    };

                    float montoTotal = t.getMontoTotal();
                                          
                    MessageBox.Show(string.Format("{0} |  Monto más aumento:{1}", t.ToString(), t.HorasTrabajadas > 8 ?  montoTotal + montoTotal * 0.1f : montoTotal), "Calculo del monto a pagar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Verifique los datos ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema\nError=>" + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}