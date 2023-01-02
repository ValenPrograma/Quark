using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Operacion
    {
        protected int valor1;
        protected int valor2;
        protected int resultado;

        public int Valor1
        {
            get
            {
                return valor1;
            }
            set
            {
                valor1 = value;
            }
        }

        public int Valor2
        {
            get
            {
                return valor2;
            }
            set
            {
                valor2 = value;
            }
        }

        public int Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }
    }

    public class Suma:Operacion 
    {
        public Suma()
        {
            Console.WriteLine("Ingresar valor1: ");
            String line = Console.ReadLine();
            Valor1 = int.Parse(line);
            Console.WriteLine("Ingresar valor2: ");
            line = Console.ReadLine();
            Valor2 = int.Parse(line);
            Resultado = Valor1 + Valor2;
        }
    }

    public class Resta:Operacion
    {
        public Resta()
        {
            Console.WriteLine("Ingresar valor1: ");
            String line = Console.ReadLine();
            Valor1 = int.Parse(line);
            Console.WriteLine("Ingresar valor2: ");
            line = Console.ReadLine();
            Valor2 = int.Parse(line);
            Resultado = Valor1 - Valor2;
        }
    }


    class Prueba
    {
        static void Main(string[] args)
        {
            /*
             * Ahora plantearemos el primer problema utilizando herencia. 
             * Supongamos que necesitamos implementar dos clases que llamaremos Suma y Resta. 
             * Cada clase tiene como atributo valor1, valor2 y resultado. 
             * Las propiedades a definir son Valor1, Valor2 y Resultado, 
             * el método Operar (que en el caso de la clase "Suma" suma los dos Valores y 
             * en el caso de la clase "Resta" hace la diferencia entre Valor1 y Valor2.
              Si analizamos ambas clases encontramos que muchas propiedades son idénticos. 
            En estos casos es bueno definir una clase padre que agrupe dichas propiedades, atributos y responsabilidades comunes.
             */

            Console.WriteLine("1. Para Sumar 2. Para Resta");
            String line = Console.ReadLine();
            int opcion = int.Parse(line);

            

            if (opcion == 1)
            {
                Suma suma = new Suma();
                Console.WriteLine(suma.Valor1 + " + " + suma.Valor2 + " = " + suma.Resultado);
            }else if(opcion == 2)
            {
                Resta resta = new Resta();
                Console.WriteLine(resta.Valor1 + " - " + resta.Valor2 + " = " + resta.Resultado);
            }
            else
            {
                Console.WriteLine("Opcion incorrecta");
            }

            
        }
    }
}
