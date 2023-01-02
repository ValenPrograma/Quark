using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while_ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que solicite la carga de números por teclado, 
             * obtener su promedio. Finalizar la carga de valores cuando se cargue el valor 0.
             * Cuando la finalización depende de algún valor ingresado por el operador 
             * conviene el empleo de la estructura do while, por lo menos se cargará un valor 
             * (en el caso más extremo se carga 0, que indica la finalización de la carga 
             * de valores)
            */
            int num;
            int promedio = 0;
            int suma = 0;
            int cont = 0;
            String line;

            Console.WriteLine("Bienvenido");
            do
            {
                
                Console.Write("Ingrese numero para obtener promedio(0 para salir): ");
                line = Console.ReadLine();
                num = int.Parse(line);
                if (num != 0){
                    suma = suma + num;
                    cont++;
                }

            } while (num != 0);
            if(cont == 0)
            {
                Console.WriteLine("No se ingreso numeros");
            }
            else
            {
                promedio = suma / cont;
                Console.WriteLine("El promedio es: " + promedio);
            }
        }
    }
}
