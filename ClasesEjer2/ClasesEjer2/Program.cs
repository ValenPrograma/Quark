using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjer2
{
    internal class MayorDeTres
    {
        private int n1, n2, n3 = 0;
        private String linea;
        public void IngresarDato()
        {
            Console.Write("Ingrese numero 1: ");
            linea = Console.ReadLine();
            n1 = int.Parse(linea);
            Console.Write("Ingrese numero 2: ");
            linea = Console.ReadLine();
            n2 = int.Parse(linea);
            Console.Write("Ingrese numero 3: ");
            linea = Console.ReadLine();
            n3 = int.Parse(linea);

            Console.WriteLine("El mayor es: " + CalcularMayor(n1, n2, n3));
            Console.WriteLine("El menor es: " + CalcularMenor(n1, n2, n3));


        }

        private int CalcularMayor(int n1, int n2, int n3)
        {
            int mayor = 0;
            if(n1>n2 && n1 > n3)
            {
                mayor = n1;
            }else if (n2>n1 && n2 > n3)
            {
                mayor = n2;
            }
            else
            {
                mayor = n3;
            }
            return mayor;
        }

        private int CalcularMenor(int n1, int n2, int n3)
        {
            int menor = 0;
            if (n1 < n2 && n1 < n3)
            {
                menor = n1;
            }
            else if (n2 < n1 && n2 < n3)
            {
                menor = n2;
            }
            else
            {
                menor = n3;
            }
            return menor;
        }


        static void Main(string[] args)
        {
            /*
             * Confeccionar una clase que permita ingresar tres valores por teclado.
             * Luego mostrar el mayor y el menor.
             */
            MayorDeTres mayorDeTres = new MayorDeTres();
            mayorDeTres.IngresarDato();
        }
    }
}
