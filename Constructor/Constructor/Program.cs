using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Operarios
    {
        private float[] sueldos;
        Operarios()
        {
            sueldos = new float[5];
            String line;
            for(int i = 0; i<sueldos.Length; i++)
            {
                Console.WriteLine("Ingresar sueldo: ");
                line = Console.ReadLine();
                sueldos[i] = float.Parse(line);
            }
        }

        public void Imprimir()
        {
            Console.Write("Sueldo: ");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write(sueldos[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            /*
             * Se desea guardar los sueldos de 5 operarios en un vector. Realizar la creación y carga del vector en el constructor.
             */
            Operarios sueldos = new Operarios();
            sueldos.Imprimir();
        }
    }
}
