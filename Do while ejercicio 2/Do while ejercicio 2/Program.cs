using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while_ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que permita ingresar el peso (en kilogramos) de piezas.
             * El proceso termina cuando ingresamos el valor 0. Se debe informar:
            a) Cuántas piezas tienen un peso entre 9.8 Kg. y 10.2 Kg.?, 
            cuántas con más de 10.2 Kg.? y cuántas con menos de 9.8 Kg.?
            b) La cantidad total de piezas procesadas.
            */
            float peso;
            String line;
            int contPiezas = 0;
            int contPesoMayor = 0;
            int contPesoMedio = 0;
            int contPesoMenor = 0;

            Console.WriteLine("Bienvenido/a");

            do
            {
                Console.Write("Ingrese el peso de la pieza (0 PARA SALIR): ");
                line = Console.ReadLine();
                peso = float.Parse(line);
                if(peso != 0)
                {
                    if (peso > 10.2)
                    {
                        contPesoMayor++;
                    }else if(peso>=9.8)
                    {
                        contPesoMedio++;
                    }
                    else if(peso>0)
                    {
                        contPesoMenor++;
                    }
                    contPiezas++;
                }
            }
            while (peso != 0);
            
            if(contPiezas == 0)
            {
                Console.WriteLine("No se ingresaron piezas");
            }
            else
            {
                Console.WriteLine("Piezas con peso entre 9.8 Kg. y 10.2 Kg = " + contPesoMedio + "\nPiezas mayor a 10.2: " + contPesoMayor + "\nPiezas menor a 9.8: " + contPesoMenor + "\nPiezas totales: " + contPiezas);
            }
        }
    }
}
