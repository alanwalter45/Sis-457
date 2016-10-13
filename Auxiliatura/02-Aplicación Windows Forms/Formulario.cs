using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _02_WindowsForms
{
    public partial class Form1 : Form
    {

        private List<Registro> listaRegistros = new List<Registro>();
        private string resultado = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                byte edad = byte.Parse(txtEdad.Text);
                if (edad >= 18 && edad <= 150)
                {
                    Registro registro = new Registro() { NombreUsuario = txtNombreCompleto.Text, EdadUsuario = edad };
                    listaRegistros.Add(registro);

                    resultado += string.Format("Id: {0} | Nombre Completo: {1} | Edad: {2} |||", registro.Id, registro.NombreUsuario, registro.EdadUsuario);

                    MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La edad debe estar comprendida entre 18 y 150 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema =>" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar ==8 || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == (char)Keys.Left || e.KeyChar == (char)Keys.Right);
        }

        private void btnListarRegistros_Click(object sender, EventArgs e)
        {
            resultado = "";
            foreach (Registro registro in listaRegistros)
            {
                resultado += string.Format("Id: {0} | Nombre Completo: {1} | Edad: {2} |||", registro.Id, registro.NombreUsuario, registro.EdadUsuario);
            }

            MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}