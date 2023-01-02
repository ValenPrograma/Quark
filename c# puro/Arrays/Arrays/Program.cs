using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class GuardarSueldo
    {
        private int[] sueldos;

        public void CargarSueldos()
        {
            sueldos = new int[5];
            for(int i = 0; i<5; i++)
            {
                Console.Write("Ingresar sueldo: ");
                String linea;
                linea = Console.ReadLine();
                sueldos[i] = int.Parse(linea);
            }
        }
        public void Imprimir()
        {
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
        }
        static void Main(string[] args)
        {
            //GUARDAR 5 SUELDOS EN ARRAY
            GuardarSueldo guardSalary = new GuardarSueldo();
            guardSalary.CargarSueldos();
            guardSalary.Imprimir();
        }
    }
}
