using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise_programming_asignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cube_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double L = Convert.ToDouble(textBox2.Text);

            double V = L * L * L;
            label4.Text = "volume = " + V;

            double S = L * L * 6.0;
            label5.Text = "Surface area = " + S;

        }
    }
}
