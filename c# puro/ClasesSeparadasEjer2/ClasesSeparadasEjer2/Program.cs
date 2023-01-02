using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesSeparadasEjer2
{
    class Socio
    {
        private String nombre;
        private int antiguedad;

        public String Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        } 
        
        public int Antiguedad
        {
            set
            {
                antiguedad = value;
            }
            get
            {
                return antiguedad;
            }
        }

        public Socio()
        {
            String line;
            Console.WriteLine("Ingrese nombre: ");
            line = Console.ReadLine();
            nombre = line;
            Console.WriteLine("Ingrese antiguedad: ");
            line = Console.ReadLine();
            antiguedad = int.Parse(line);
        }

       
    }
    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public String MasAntiguedad()
        {
            String masAntiguedad;
            if(socio1.Antiguedad > socio2.Antiguedad && socio1.Antiguedad > socio3.Antiguedad)
            {
                masAntiguedad = socio1.Nombre;
            }else if (socio2.Antiguedad > socio1.Antiguedad && socio2.Antiguedad > socio3.Antiguedad)
            {
                masAntiguedad = socio2.Nombre;
            }
            else
            {
                masAntiguedad = socio3.Nombre;
            }

            return masAntiguedad;
        }

        public void imprimirMasAntiguo()
        {
            Console.WriteLine("Nombre del socio mas antiguo: " + MasAntiguedad());
        }
        static void Main(string[] args)
        {
            /*
             * Plantear una clase Club y otra clase Socio.
               La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club (en años). 
               En el constructor pedir la carga del nombre y su antigüedad. 
               La clase Club debe tener como atributos 3 objetos de la clase Socio.
               Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
             */
            Club clubMasAntiguo =  new Club();
            clubMasAntiguo.imprimirMasAntiguo();
        }
    }
}
