using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace grupo_03
{
    public partial class Form1 : Form
    {
        private List<Forma> listaFormas = new List<Forma>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listaFormas.Add(new Forma() { Figura = Figuras.cuadrado, CantidadParametros = 1, Formula = new Bitmap(Application.StartupPath + "/img/Cuadrado.png") });
            listaFormas.Add(new Forma() { Figura = Figuras.rectangulo, CantidadParametros = 2, Formula = new Bitmap(Application.StartupPath + "/img/Rectangulo.png") });
            listaFormas.Add(new Forma() { Figura = Figuras.triangulo, CantidadParametros = 2, Formula = new Bitmap(Application.StartupPath + "/img/Triangulo.png") });
            listaFormas.Add(new Forma() { Figura = Figuras.circunferencia, CantidadParametros = 1, Formula = new Bitmap(Application.StartupPath + "/img/Circunferencia.png") });

            cbForma.DataSource = listaFormas;
            cbForma.DisplayMember = "Figura";
            
        }

       
        private void cbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            foreach (Forma forma in listaFormas)
            {
              
                if (forma.Figura == ((Forma)cbForma.SelectedItem).Figura)
                {
                    pbFormula.Image = forma.Formula;

                    Random r=new Random();
                    btnCalcular.BackColor = Color.FromArgb(r.Next(0, 255),r.Next(0,255),r.Next(0,255));

                    npN2.Visible = forma.CantidadParametros > 1 ;

                    break;
                }
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            foreach (Forma forma in listaFormas)
            {
                if (forma.Figura == ((Forma)cbForma.SelectedItem).Figura)
                {
                    try
                    {
                        float area = forma.Calcular(forma.Figura, (float)npN1.Value, (float)npN2.Value);
                        MessageBox.Show("El Área es :" + area.ToString());
                        break;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error de comprobación de datos =>"+ex.Message);
                    }
                    
                }
            }
        }
    }
}
