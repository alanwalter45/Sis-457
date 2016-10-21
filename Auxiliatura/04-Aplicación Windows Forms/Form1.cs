using System;
using System.Threading;
using System.Windows.Forms;

namespace _04_WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private Thread t;
        private delegate void ModificarHoraDelegate(string hora);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(ContarImPares);
            t = new Thread(ts);
            t.Start();

            while (contadorPares<=10)
            {
                ContarPares();
            }

        }

        private int contadorPares = 2;
        private void ContarPares()
        {
            MessageBox.Show(contadorPares.ToString());
            contadorPares += 2;
        }

        private int contadorImpares = 1;
        private void ContarImPares()
        {
            while (contadorImpares <= 9)
            {
                MessageBox.Show(contadorImpares.ToString());
                contadorImpares+=2;
            }
        }   

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
        }

    }
}