using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioUno
{
    public partial class ventanaImg : Form
    {
        public ventanaImg()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath+"/2.jpg");
        }

        private void ventanaImg_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "/1.jpg");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "/3.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "/4.jpg");
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "/5.jpg");
        }
    }
}
