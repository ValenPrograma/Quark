using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSuperficie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado = 0;
            String line;

            Console.WriteLine("Bienvenido");
            Console.Write("Ingrese lado para saber su superficie: ");
            line = Console.ReadLine();
            lado = int.Parse(line);
            Console.WriteLine("La superficie es: " + (lado * lado));

        }
    }
}
