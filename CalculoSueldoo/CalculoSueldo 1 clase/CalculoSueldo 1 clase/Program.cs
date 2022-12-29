using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSueldo_1_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String linea;
            int horasTrabajadas = 0;
            Console.WriteLine("Bienvenido/a");
            Console.Write("Ingrese las horas trabajadas: ");
            linea = Console.ReadLine();
            horasTrabajadas = int.Parse(linea);
            int CostoDeHora = 0;
            Console.Write("Ingrese costo de hora: $");
            linea = Console.ReadLine();
            CostoDeHora = int.Parse(linea);

            void Calculo(int horasTrabajadass, int CostoDeHoraa)
            {
                Console.WriteLine("La suma es: " + (horasTrabajadas * CostoDeHora));
            }

            Calculo(horasTrabajadas, CostoDeHora);
        }
    }
}
