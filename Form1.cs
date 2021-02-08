using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pasar(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation ="C:/Users/Ivanesa/Desktop/cv_vanesa/vsp.jpg";
        }

        private void leave(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/Ivanesa/Desktop/cv_vanesa/gitata.jpg";
        }
    }
}
