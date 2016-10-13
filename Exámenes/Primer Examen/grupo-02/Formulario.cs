using System;
using System.Windows.Forms;

namespace grupo_02
{
    public partial class Form1 : Form
    {

        private Juego juego = new Juego();

        public Form1()
        {
            InitializeComponent();
        }
      
        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            try
            {
                byte numero = (byte)txtNumero.Value;
               
                juego.NumeroIntentos++;

                if(numero==juego.NumeroAdivinar)
                {
                    juego.Gano = true;
                    MessageBox.Show("Feliciades usted ganó.", "Ganaste :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    juego = new Juego(); 
                }
                else
                {
                    MessageBox.Show(numero > juego.NumeroAdivinar ? "El número ingresado es muy alto" : "El número ingresado es muy bajo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                if(juego.NumeroIntentos>=juego.NumeroTotalIntentos && juego.Gano==false)
                {
                    MessageBox.Show("Perdió, el número era: " + juego.NumeroAdivinar,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    juego = new Juego();          
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique los datos =>" +ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}