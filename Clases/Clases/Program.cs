using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Persona
    {
        private string nombre;
        private int edad;

        public void CargarDatos()
        {
            Console.Write("Ingrese nombre: ");
            String linea;
            nombre = Console.ReadLine();
            do
            {
                Console.Write("Ingrese edad: ");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
            } while (edad < 0);
            
        }
        
        public void ImprimirDatos()
        {
            Console.WriteLine("\nDatos: \nNombre: " + nombre + "\nEdad: " + edad);
        }

        public bool isMayorEdad(int edad)
        {
            return edad >= 18;
        }
        
        public void Inicia()
        {
            CargarDatos();
            ImprimirDatos();
            if (isMayorEdad(edad)){
                Console.WriteLine("ES MAYOR DE EDAD");
            }
            else
            {
                Console.WriteLine("ES MENOR DE EDAD");
            }
        }
        static void Main(string[] args)
        {
            /*Confeccionar una clase que permita carga el nombre y la edad de una persona. 
             * Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18)
             */
            Persona per1 = new Persona();
            per1.Inicia();
        }
    }
}
