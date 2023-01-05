using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "";  //Iniciar el form sin titulo

            if(checkBox1.Checked == true)
            {
                Text = Text + ("Ingles");
            }else if (checkBox2.Checked == true)
            {
                Text = Text + ("Español");
            }else if (checkBox3.Checked == true)
            {
                Text = Text + ("Portugues");
            }

        }
    }
}
