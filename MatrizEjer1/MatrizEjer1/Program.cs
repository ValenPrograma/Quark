using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizEjer1
{
    class Matrizz
    {
        private int[,] matriz;
        public void IngresarDatos()
        {
            String line;

            Console.WriteLine("Ingrese el numero de filas de la matriz: ");
            line = Console.ReadLine();
            int nf = int.Parse(line);

            Console.WriteLine("Ingrese el numero de columpnas de la matriz: ");
            line = Console.ReadLine();
            int nc = int.Parse(line);

            matriz = new int[nf,nc];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int i2 = 0; i2 < matriz.GetLength(1); i2++)
                {
                    Console.Write("Ingresar matriz: fila " + i + " Comlumpna " + i2 + " : ");
                    line = Console.ReadLine();
                    matriz[i, i2] = int.Parse(line);
                }
            }
        }
        
        public void Imprimir()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int i2 = 0; i2 < matriz.GetLength(1); i2++)
                {
                    Console.Write(matriz[i, i2]+ " ");
                }
                Console.WriteLine("");
            }
        }

        public void Iniciar()
        {
            IngresarDatos();
            Imprimir();
        }
        static void Main(string[] args)
        {
            /*
             * Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir la matriz completa y la última fila.
             */
            Matrizz matriz = new Matrizz();
            matriz.Iniciar();
        }
    }
}
