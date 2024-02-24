using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuarto_ejer
{
    public partial class Form1 : Form
    {
        private String ruta="";

        bool play = false;
        string [] ArchivosMp3;
        string [] RutasArchivos;
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Si lo desea puede adjuntar muhchas canciones al mismo tiempo pero es algo que\n se podra hacer una vez por inicio asi que selleccione todas de su agrado";
        }

        double a = 0.00, b = 0.00, c = 0.00;
        double d = 0.000;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //con esta funcion buscamos la direccion con la herramienta openFilidialog que esta en el ciadro de herramientas
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
            }

        }
        // esta funcio realisa la operacion la cual es agarrar la ruta y ponerla como direccion en la pagina de windows Media player para despues reproduccirla
        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            reproductor_musica.Ctlcontrols.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            reproductor_musica.Ctlcontrols.stop();
        }

        private void resultadoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void promTresText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (promUnoText.Text == "" || promDosText.Text == "" || promTresText.Text == "")
            {
                MessageBox.Show("Ingrese las calificaciones", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                a = double.Parse(promUnoText.Text);
                b = double.Parse(promDosText.Text);
                c = double.Parse(promTresText.Text);

                if (a < 100 && b < 100 && c < 100)
                {
                    d = (a + b + c) / 3;
                    resultadoText.Text = d.ToString();
                }
                else
                {
                    MessageBox.Show("Las Calificaciones deben de estar\ndebajo 100", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void promTresText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void addjuntar_Click(object sender, EventArgs e)
        {
            buscadordeArchivos.Multiselect = true;
            if (buscadordeArchivos.ShowDialog() == DialogResult.OK)
            {
                ArchivosMp3 = buscadordeArchivos.SafeFileNames;
                RutasArchivos = buscadordeArchivos.FileNames;
                foreach (var ArchivoMp3 in ArchivosMp3)
                {
                    lista_de_musica.Items.Add(ArchivoMp3);
                }
                reproductor_musica.URL=(RutasArchivos[0]);
                lista_de_musica.SelectedIndex=0;
            }
            addjuntar.Enabled = false;

        }

        private void lista_de_musica_SelectedIndexChanged(object sender, EventArgs e)
        {
            reproductor_musica.URL = RutasArchivos[lista_de_musica.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void promUnoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void promDosText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
