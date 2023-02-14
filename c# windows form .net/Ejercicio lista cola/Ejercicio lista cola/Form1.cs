using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_lista_cola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ale = new Random();  //Invoca un objeto random
            int estado = 0; //estado almacena un cero si el cajero está libre y un uno cuando está ocupado.
            int llegada = 2 + ale.Next(0, 2);  //almacena en que minuto llegará el próximo cliente (debemos generar un valor entre 2 y 3)
            //Creamos un objeto de la clase Random para poder utilizar el método Next que nos retorna un valor aleatorio en el rango que le pasamos como parámetros (si pasamos un 0 y 2 luego nos puede retornar un 0 o un 1)
            int salida = -1;//salida almacenará en que minuto terminará el cliente de ser atendido (como al principio el cajero está vacío inicializamos esta variable con -1)
            int cantidadAtendida = 0; 
            Cola cola = new Cola();//Luego definimos un objeto de la clase Cola para poder almacenar las personas que llegan al cajero y se lo encuentran ocupado.

            for (int minutos = 0; minutos < 600; minutos++)
            {
                if(llegada == minutos)//Si llegada (osea cuando llega el proximo cliente) es igual al minuto actual, tiene que se atendido
                {
                    if(estado == 0)
                    {
                        estado = 1;
                        salida = minutos + 2 + ale.Next(0, 4);
                    }
                    else
                    {
                        cola.Agregar(minutos);
                    }
                    llegada = minutos + 2 + ale.Next(0, 2);
                }
                if (salida == minutos)
                {
                    estado = 0;
                    cantidadAtendida++;
                    if (!cola.Vacio())
                    {
                        cola.Extraer();
                        estado = 1;
                        salida = minutos + 2 + ale.Next(0, 4);
                    }
                }
            }
            label1.Text = "Atendidos: " + cantidadAtendida.ToString();
            label2.Text = "En cola: " + cola.Cantidad().ToString();
            label3.Text = "Minuto llegada: " + cola.Extraer().ToString(); 
        }
    }
}
