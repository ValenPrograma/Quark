using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEjer3
{
    class SumarVector
    {
        private float[] numeros;
        String line;
        public void IngresarDatos()
        {
            Console.WriteLine("Cuantos numeros quiere sumar? ");
            line = Console.ReadLine();
            int n = int.Parse(line);
            numeros = new float[n];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese numero: ");
                line = Console.ReadLine();
                numeros[i] = float.Parse(line);
            }
        }
        public void SumarElementos()
        {
            float suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma = suma + numeros[i];
            }
            Console.WriteLine("La suma es: " + suma);
        }

        public void Iniciar()
        {
            IngresarDatos();
            SumarElementos();
        }
        
        static void Main(string[] args)
        {
            /*
             * Desarrollar un programa que permita ingresar un vector de n elementos, 
             * ingresar n por teclado. Luego imprimir la suma de todos sus elementos
             */
            SumarVector sumarVectores = new SumarVector();
            sumarVectores.Iniciar();
        }
    }
}
