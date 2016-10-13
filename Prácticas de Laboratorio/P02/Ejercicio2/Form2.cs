using System;
using System.Windows.Forms;

namespace practica_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                string sexo = "Masculino";
                if (!rbtnMasculino.Checked)
                    sexo = "Femenino";

                Estudiante estudiante = new Estudiante()
                {
                    Nombre = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    FechaNacimiento = txtFechaNacimiento.Value,
                    Sexo=sexo,
                    CarnetUniversitario = txtCarnetUniversitario.Text,
                    Email = txtEmail.Text,
                    Notificaciones = cbRecibirNotificaciones.Checked
                };

                if (txtNombres.Text.Length > 0 && txtApellidos.Text.Length > 0 && txtFechaNacimiento.Value != null 
                    && txtCarnetUniversitario.Text.Length > 0 && txtEmail.Text.Length > 0)
                {
                    
                    string notificacionStr = string.Format(@"Registo guardado exitosamente:
                    ------------------------------------   
                    Nombre Completo:{0}
                    Dirección:{1}
                    Telefono:{2}
                    Edad:{3}
                    Sexo:{4}
                    Carnet Universitario:{5}
                    Email:{6}
                    ------------------------------------
                    {7}", estudiante.Nombre + " " + estudiante.Apellidos, 
                        estudiante.Direccion, 
                        estudiante.Telefono, 
                        estudiante.getEdad(), 
                        estudiante.Sexo, 
                        estudiante.CarnetUniversitario,estudiante.Email, 
                        estudiante.Notificaciones ? "Recibirá notificaciones" : "No se habilitó para recibir notificaciones");

                    MessageBox.Show(notificacionStr, "Información", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Datos inválidos,Revise los datos ingresados.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos inválidos\nError=>" + ex.Message);
            }
        }
    }
}