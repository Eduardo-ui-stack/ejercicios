using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Actividad echa y validada por sosa vera jesus Eduardo
/// </summary>
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private char decimalSeparator;

        public Form1()
        {
            // se decalro una variable tipo timer para poder contar o hacer el temporizador
            temer = new Timer();
            InitializeComponent();


            // intervalo = a tiempo de ejecucion en milisegundos
            temer.Interval = 6000;
            //se le suma al rejoj el cual es una funcion para que se puedan enlazar se nesesitan  una variable tipo temer y la funcion tick 
            temer.Tick += reloj;
        }
        private void reloj (object sender, EventArgs e)
        {
            label6.Visible = false;
            label5.Visible = false;

            temer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   // definimos el boton que se encargara de darnos el valor en dolares con una pequeña validacion
            double num = 1.00;
            double result = 0.00;
            label5.Visible = true;
            if (textBox1.TextLength == 0)
            {
                result = num * 0.056;
                label5.Text = result + "\nValor del dolar ";
            }
            else
            {
                num = Convert.ToDouble(textBox1.Text);
                result = num * 0.056;
                label5.Text = result + "";
            }

            temer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // lo mismo de la funcion clik de dolar pero en euros
            double num = 1.00;
            double result =0.00;
            label6.Visible = true;
            if (textBox1.TextLength == 0)
            {
                result = num * 0.054;
                label6.Text = result + "\nValor del euro ";
            }
            else
            {
                num = Convert.ToDouble(textBox1.Text);
                result = num * 0.054;
                label6.Text = result + "";
            }
 
            temer.Start();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se valida con el keypress ademas de validar las entradas de numeros
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == decimalSeparator)
            {
                e.Handled = false; // No hacemos nada y dejamos que el sistema controle la pulsación de tecla
            }
            else
            {
                e.Handled = true; // Interceptamos la pulsación para que no tenga lugar
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void label2_MouseEnter(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
    }
}
