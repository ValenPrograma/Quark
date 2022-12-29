using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfAnidadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Confeccionar un programa que pida por teclado tres notas de un alumno,
            /calcule el promedio e imprima alguno de estos mensajes:
            Si el promedio es >= 7 mostrar "Promocionado".
            Si el promedio es >= 4 y < 7 mostrar "Regular".
            Si el promedio es<4 mostrar "Reprobado".
            */

            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int promedio = 0;
            String line;

            Console.WriteLine("Bienvenido");
            Console.Write("Ingrese nota 1: ");
            line = Console.ReadLine();
            nota1 = int.Parse(line);

            Console.Write("Ingrese nota 2: ");
            line = Console.ReadLine();
            nota2 = int.Parse(line);

            Console.Write("Ingrese nota 3: ");
            line = Console.ReadLine();
            nota3 = int.Parse(line);

            promedio = (nota1 + nota2 + nota3) / 3;

            if(promedio>= 7)
            {
                Console.WriteLine("Promocionado");
            }else if(promedio>= 4 && promedio < 7)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
        }
    }
}
