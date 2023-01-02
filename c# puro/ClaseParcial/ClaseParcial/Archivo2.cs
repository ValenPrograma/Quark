using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial
{
    partial class Rectangulo
    {
        public Rectangulo()
        {
            Console.WriteLine("Ingrese lado1: ");
            String line = Console.ReadLine();
            Lado1 = int.Parse(line);
            Console.WriteLine("Ingrese lado2: ");
            line = Console.ReadLine();
            Lado2 = int.Parse(line);

            Console.WriteLine("La superficie es: " + RetornarSuperficie());
            Console.WriteLine("El perimetro es: " + RetornarPerimetro());


        }
        public int RetornarSuperficie()
        {
            int superficie = Lado1 * Lado2;
            return superficie;
        }
        public int RetornarPerimetro()
        {
            int perimetro = Lado1 * 2 + Lado2 * 2;
            return perimetro;
        }
    }
}
