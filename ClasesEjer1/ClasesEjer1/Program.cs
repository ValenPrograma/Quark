using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjer1
{
    internal class TablaMultiplicar
    {
        int valor;
        String linea;

        public void calcularTabla(int valor)
        {
            for (int i = 0; i <= 10; i = i + 1)
            {
                Console.WriteLine(valor + " x " + i + " = " + (valor * i));
            }
        }

        public void IngresarDato()
        {
            do
            {
                Console.Write("Ingrese valor (-1 PARA SALIR): ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if(valor != -1)
                {
                    calcularTabla(valor);
                }
                else
                {
                    Console.WriteLine("Fin");
                }
            } while (valor != -1);
           
        }

        public void Iniciar()
        {
            IngresarDato();
        }

        static void Main(string[] args)
        {
            /*
             * Confeccionar una clase que permita ingresar valores enteros por teclado y 
             * nos muestre la tabla de multiplicar de dicho valor. Finalizar el programa al ingresar el -1.
             */
            TablaMultiplicar tabla = new TablaMultiplicar();
            tabla.Iniciar();
        }
    }
}
