using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que solicite la carga de un número entre 0 y 999,
             * y nos muestre un mensaje de cuántos dígitos tiene el mismo. 
             * Finalizar el programa cuando se cargue el valor 0.
            */

            Console.WriteLine("Bienvenido");
            int num;
            String line;
            do
            {
                Console.Write("Ingrese un valor entre 0 y 999 (0 finaliza): ");
                line = Console.ReadLine();
                num = int.Parse(line);
                if (num == 100)
                {
                    Console.WriteLine("Tiene 3 digitos");
                }
                else if (num >= 10)
                {
                    Console.WriteLine("Tiene 2 digitos");
                }
                else if (num >=1)
                {
                    Console.WriteLine("Tiene 1 digito");
                }
                
            } while (num != 0);
        }
    }
}
