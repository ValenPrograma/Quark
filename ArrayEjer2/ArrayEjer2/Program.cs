using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEjer2
{
    class Vectores
    {
        private int[] vector1;
        private int[] vector2;
        private int[] vector3;

        public void CargarVectores()
        {
            vector1 = new int[4];
            vector2 = new int[4];
            String line;
            for (int i = 0; i < vector1.Length; i++){
                Console.Write("Ingresar enteros del primer vector: ");
                line = Console.ReadLine();
                vector1[i] = int.Parse(line);
            }
            Console.WriteLine("Listo, Siguiente vector.");
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.Write("Ingresar enteros del segundo vector: ");
                line = Console.ReadLine();
                vector2[i] = int.Parse(line);
            }
            Console.WriteLine("Listo");
        }

        public void sumarUnoAUno()
        {
            vector3 = new int[4];
            for(int i = 0; i<vector3.Length; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }

            Console.WriteLine("El resultado del vector es: ");

            for (int i = 0; i < vector3.Length; i++)
            {
                Console.WriteLine(vector3[i]);
            }
        }

        public void Iniciar()
        {
            CargarVectores();
            sumarUnoAUno();
        }
        static void Main(string[] args)
        {
            /*
             * Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos. 
             * Obtener la suma de los dos vectores, dicho resultado guardarlo en un tercer vector del mismo tamaño.
             * Sumar componente a componente.
             */
            Vectores vectoresSumar = new Vectores();
            vectoresSumar.Iniciar();
        }
    }
}
