using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTres
{
    public partial class ejercicioTres : Form
    {
        public ejercicioTres()
        {
            InitializeComponent();
            
        }

        private void ejercicioTres_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "/1.jpg");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1105, 649);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(100,100);
            
        }
    }
}
