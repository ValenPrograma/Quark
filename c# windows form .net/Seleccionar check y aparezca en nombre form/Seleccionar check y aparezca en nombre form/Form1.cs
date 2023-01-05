using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seleccionar_check_y_aparezca_en_nombre_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        
            Text = "";

            if(checkBox1.Checked == true)
            {
                Text = Text + "(" + checkBox1.Text + ")";
            }
            if (checkBox2.Checked == true)
            {
                Text = Text + "(" + checkBox2.Text + ")";
            }
            if (checkBox3.Checked == true)
            {
                Text = Text + "(" + checkBox3.Text + ")";
            }
        }
        
        
    }
}
