using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioListaTipoCola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Random ale = new Random();
                int estado1 = 0, estado2 = 0, estado3 = 0;
                int marchan = 0;
                int llegada = 2 + ale.Next(0, 2);
                int salida1 = -1, salida2 = -1, salida3 = -1;
                int cantAte1 = 0, cantAte2 = 0, cantAte3 = 0;
                int tiempoEnCola = 0;
                int cantidadEnCola = 0;
                Cola cola1 = new Cola();
                Cola cola2 = new Cola();
                Cola cola3 = new Cola();
                for (int minuto = 0; minuto < 600; minuto++)
                {
                    if (llegada == minuto)
                    {
                        if (estado1 == 0)
                        {
                            estado1 = 1;
                            salida1 = minuto + 7 + ale.Next(0, 5);
                        }
                        else
                        {
                            if (estado2 == 0)
                            {
                                estado2 = 1;
                                salida2 = minuto + 7 + ale.Next(0, 5);
                            }
                            else
                            {
                                if (estado3 == 0)
                                {
                                    estado3 = 1;
                                    salida3 = minuto + 7 + ale.Next(0, 5);
                                }
                                else
                                {
                                    if (cola1.Cantidad() == 6 && cola2.Cantidad() == 6 && cola3.Cantidad() == 6)
                                    {
                                        marchan++;
                                    }
                                    else
                                    {
                                        if (cola1.Cantidad() <= cola2.Cantidad() && cola1.Cantidad() <= cola3.Cantidad())
                                        {
                                            cola1.Insertar(minuto);
                                        }
                                        else
                                        {
                                            if (cola2.Cantidad() <= cola3.Cantidad())
                                            {
                                                cola2.Insertar(minuto);
                                            }
                                            else
                                            {
                                                cola3.Insertar(minuto);
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        llegada = minuto + 2 + ale.Next(0, 2);
                    }
                    if (salida1 == minuto)
                    {
                        cantAte1++;
                        estado1 = 0;
                        if (!cola1.Vacia())
                        {
                            estado1 = 1;
                            int m = cola1.Extraer();
                            salida1 = minuto + 7 + ale.Next(0, 5);
                            tiempoEnCola = tiempoEnCola + (minuto - m);
                            cantidadEnCola++;
                        }
                    }
                    if (salida2 == minuto)
                    {
                        cantAte2++;
                        estado2 = 0;
                        if (!cola2.Vacia())
                        {
                            estado2 = 1;
                            int m = cola2.Extraer();
                            salida2 = minuto + 7 + ale.Next(0, 5);
                            tiempoEnCola = tiempoEnCola + (minuto - m);
                            cantidadEnCola++;
                        }
                    }
                    if (salida3 == minuto)
                    {
                        cantAte3++;
                        estado3 = 0;
                        if (!cola3.Vacia())
                        {
                            estado3 = 1;
                            int m = cola3.Extraer();
                            salida3 = minuto + 7 + ale.Next(0, 5);
                            tiempoEnCola = tiempoEnCola + (minuto - m);
                            cantidadEnCola++;
                        }
                    }
                }
                label1.Text = "Clientes atendidos por caja: caja1=" + cantAte1.ToString() + "  caja2=" + cantAte2.ToString() + "  caja3=" + cantAte3.ToString();
                label2.Text = "Se marchan sin hacer compras:" + marchan.ToString();
                if (cantidadEnCola > 0)
                {
                    int tiempoPromedio = tiempoEnCola / cantidadEnCola;
                    label3.Text = "Tiempo promedio en cola:" + tiempoPromedio.ToString();
                }
            }
        }
    }
}

