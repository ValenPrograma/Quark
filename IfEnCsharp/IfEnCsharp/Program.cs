using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfEnCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sueldo = 0;
            String line;

            Console.WriteLine("Bienvenido/a");
            Console.Write("Ingrese tu sueldo para ver si tiene que pagar impuestos: $");
            line = Console.ReadLine();
            sueldo = float.Parse(line);
            if (sueldo > 3000)
            {
                Console.WriteLine("Pagar impuestos");
            }
            else
            {
                Console.WriteLine("No pagar impuestos");
            }
            
        }
    }
}
