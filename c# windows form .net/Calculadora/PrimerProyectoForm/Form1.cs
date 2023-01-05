using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyectoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + button3.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Text.Length < 12)
            {
                label1.Text = label1.Text + button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + button2.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + button9.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + button10.Text;
            }
        }
    }
}
