using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioDos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a;
        float[] numeroVector = new float[10];

        private void Form1_Load(object sender, EventArgs e)
        {
            numerosLista.Visible = false;
            progressBar1.Visible = false;
        }

        private void numeroBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void numeroBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {

            if(numeroBox.Text=="")
            {
                MessageBox.Show("Ingrese primero un valor", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            {
                if (a == 9)
                {
                    numeroVector[a] = float.Parse(numeroBox.Text);
                    pruebaBox.Text = numeroBox.Text;
                    numeroBox.Clear();
                    a = a+ 1;
                    agregarButton.Visible = false;
                    numeroBox.Visible = false;
                    label1.Text = "Calculando...";
                    Array.Sort(numeroVector);
                    
                    for (int i=0; i<=9; i++)
                    {
                        numerosLista.Items.Add(numeroVector[i]);
                    }


                    timerUno.Start();
                    
                    
                }else
                {
                    numeroVector[a] = float.Parse(numeroBox.Text);
                    pruebaBox.Text = numeroBox.Text;
                    numeroBox.Clear();
                    a = a + 1;

                }
            }

        }

        private void timerUno_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                numerosLista.Visible = true;
                Font fuente = new Font("Times New Roman", 26);
                label1.Font = fuente;
                this.BackColor=Color.FromArgb(37,32,32);
                label1.Text = "¡Valores ordenados!";

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void numerosLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
