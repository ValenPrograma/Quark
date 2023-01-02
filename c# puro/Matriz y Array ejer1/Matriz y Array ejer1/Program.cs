using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_y_Array_ejer1
{
    class Sueldos
    {
        private String[] nombres;
        private float [,] matrizSueldos;
        private float[] sueldoTotal;
        private String line;

        private void IngresarDatos()
        {
            nombres = new string[4];
            matrizSueldos = new float[4, 3];
            sueldoTotal = new float[4];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese nombre del empleado: ");
                line = Console.ReadLine();
                nombres[i] = line;
                for (int i2 = 0; i2 < matrizSueldos.GetLength(1); i2++)
                {
                        Console.WriteLine("Ingresar los 3 sueldos: ");
                        line = Console.ReadLine();
                        matrizSueldos[i, i2] = float.Parse(line);    
                }
            }
        }

        public void SumaDeEmpleado()
        {
            for (int i = 0; i < matrizSueldos.GetLength(0); i++)
            {
                float suma = 0;
                for (int i2= 0; i2 < matrizSueldos.GetLength(1); i2++)
                {
                    suma = suma + matrizSueldos[i, i2];
                }
                sueldoTotal[i] = suma;
            }
        }

        public void Imprimir()
        {
            float mayor = 0;
            int pos = 0;
            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Nombre: " + nombres[i] + " $" + sueldoTotal[i]);
            }

            for (int i = 0; i < sueldoTotal.Length; i++)
            {
                if (sueldoTotal[i] > mayor)
                {
                    mayor = sueldoTotal[i];
                    pos = i;
                }
            }
            Console.WriteLine("\nMAYOR INGRESO:\nNombre: " + nombres[pos] + " $" + mayor);
        }

        public void Iniciar()
        {
            IngresarDatos();
            SumaDeEmpleado();
            Imprimir();

        }
        static void Main(string[] args)
        {
            /*
             * Se tiene la siguiente información:
               · Nombres de 4 empleados.
               · Ingresos en concepto de sueldo, cobrado por cada empleado, en los últimos 3 meses.
               Confeccionar el programa para:

               a) Realizar la carga de la información mencionada.
               b) Generar un vector que contenga el ingreso acumulado en sueldos en los últimos 3 meses para cada empleado.
               c) Mostrar por pantalla el total pagado en sueldos a todos los empleados en los últimos 3 meses
               d) Obtener el nombre del empleado que tuvo el mayor ingreso acumulado
             */
            Sueldos sueldo = new Sueldos();
            sueldo.Iniciar();
        }
    }
}
