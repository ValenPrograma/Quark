using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    class Matriz
    {
        private int[,] matriz;

        public void IngresarDatos()
        {
            matriz = new int[3, 5];
            String line;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int i2 = 0; i2 < matriz.GetLength(1); i2++)
                {
                    Console.Write("Ingrese numero: ");
                    line = Console.ReadLine();
                    matriz[i, i2] = int.Parse(line);
                }
            }
        }

        public void ImprimirDatos()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int i2 = 0; i2 < matriz.GetLength(1); i2++)
                {
                    Console.Write(matriz[i, i2]+" ");
                }
                Console.WriteLine("");
            }
        }

        public void Iniciar()
        {
            IngresarDatos();
            ImprimirDatos();
        }
        static void Main(string[] args)
        {
            /*
             * Crear una matriz de 3 filas por 5 columnas con elementos de tipo int, cargar sus componentes
             * y luego imprimirlas.
             */
            Matriz matriz1 = new Matriz();
            matriz1.Iniciar();
        }
    }
}
