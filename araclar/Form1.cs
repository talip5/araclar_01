using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araclar
{
    public partial class Form1 : Form
    {
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "       ";
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            i = 0;
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = i.ToString();
            i++;
            if (i>=50)
            {
                label1.Text = "Merhaba";
                timer1.Stop();
            }
        }
    }
}
