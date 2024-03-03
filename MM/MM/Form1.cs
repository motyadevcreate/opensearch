using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string Search = textBox1.Text;

            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.google.com/search?q=" + Search);
            Process.Start(sInfo);
        }
    }
}
