using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_PaletaDeColores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(comboBox1.Text);
            int verde = int.Parse(comboBox2.Text);
            int azul = int.Parse(comboBox3.Text);
            BackColor = Color.FromArgb(rojo, verde, azul);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <= 255; i++)
            {
                comboBox1.Items.Add(i.ToString());
                comboBox2.Items.Add(i.ToString());
                comboBox3.Items.Add(i.ToString());
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }
    }
}
