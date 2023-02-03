using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Problema_de_lista_tipo_pila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pila pila1;
            pila1 = new Pila();
            string cadena = textBox1.Text;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena.ElementAt(i) == '(' || cadena.ElementAt(i) == '[' || cadena.ElementAt(i) == '{')
                {
                    pila1.Insertar(cadena.ElementAt(i));
                }
                else
                {
                    if (cadena.ElementAt(i) == ')')
                    {
                        if (pila1.Extraer() != '(')
                        {
                            Text = "Incorrecto";
                            return;
                        }
                    }
                    else
                    {
                        if (cadena.ElementAt(i) == ']')
                        {
                            if (pila1.Extraer() != '[')
                            {
                                Text = "Incorrecto";
                                return;
                            }
                        }
                        else
                        {
                            if (cadena.ElementAt(i) == '}')
                            {
                                if (pila1.Extraer() != '{')
                                {
                                    Text = "Incorrecto";
                                    return;
                                }
                            }
                        }

                    }

                }
            }

            if (pila1.Vacia())
            {
                Text = "Correcto";
            }
            else
            {
                Text = "Incorrecto";
            }
        }
    }
}
