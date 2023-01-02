using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEjer1
{
    class Alturas
    {
        private float[] alturas;

        public void cargarAlturas()
        {
            alturas = new float[5];
            for(int i = 0; i<5; i++)
            {
                Console.Write("Ingresar altura: ");
                String linea;
                linea = Console.ReadLine();
                alturas[i] = float.Parse(linea);
            }
        }

        public float PromedioAlturas()
        {
            float suma = 0;
            float promedio = 0;
            for (int i = 0; i < 5; i++)
            {
                suma = suma + alturas[i];
            }
            promedio = suma / 5;
            return promedio;
        }

        public void MasAltasYmasBajasQuePromedio()
        {
            int contadorMayorPromedio = 0;
            int contadorMenorPromedio = 0;
            for (int i = 0; i<5; i++)
            {
                if (alturas[i] > PromedioAlturas())
                {
                    contadorMayorPromedio++;
                }
                else
                {
                    contadorMenorPromedio++;
                }
            }
            Console.WriteLine("Personas con mayor altura que el promedio: " + contadorMayorPromedio);
            Console.WriteLine("Personas con menor altura que el promedio: " + contadorMenorPromedio);

        }

        public void Iniciar()
        {
            cargarAlturas();
            Console.WriteLine("El promedio es: " + PromedioAlturas());
            MasAltasYmasBajasQuePromedio();

        }


        static void Main(string[] args)
        {
            //Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas.
            //Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.
            Alturas alturas = new Alturas();
            alturas.Iniciar();
        }
    }
}
