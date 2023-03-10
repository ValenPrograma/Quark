using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSeparadasEjer1
{
    class Dados
    {
        private int valor;

        public int Valor
        {
            set
            {
                valor = value;
            }
            get{
                return valor;
            }
        }

        private static Random aleatorio;

        public Dados()
        {
            aleatorio = new Random();
        }
        public void Tirar()
        {
            Valor = aleatorio.Next(1, 7);
        }

        public void Imprimir()
        {
            Console.WriteLine("El valor del dado es: " + Valor);
        }

        

    }

    class juegoDados
    {
        private Dados dado1, dado2, dado3;

        public juegoDados()
        {
            dado1 = new Dados();
            dado2 = new Dados();
            dado3 = new Dados();
        }

        public void Jugar()
        {
            dado1.Tirar();
            dado2.Tirar();
            dado3.Tirar();
            dado1.Imprimir();
            dado2.Imprimir();
            dado3.Imprimir();

            if (dado1.Valor == dado2.Valor && dado2.Valor == dado3.Valor)
            {
                Console.WriteLine("Gano");
            }
            else
            {
                Console.WriteLine("Perdio");
            }
        }
    
        static void Main(string[] args)
        {
            /*
             * Plantear un programa que permita jugar a los dados. Las reglas de juego son: 
             * se tiran tres dados si los tres salen con el mismo valor mostrar un mensaje que "gano", sino "perdió".
             */
            juegoDados juegoDados = new juegoDados();
            juegoDados.Jugar();
        }
    }
}
