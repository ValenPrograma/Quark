using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjer1
{
    public class Persona
    {
        protected String nombre;
        protected int edad;

        public String Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public void ImprimirNombreEdad()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
        }
    }

    public class Empleado : Persona
    {
        protected float sueldo;

        public float Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = value;
            }
        }

        public void ImprimirSueldo()
        {
            Console.WriteLine("Sueldo: " + Sueldo);
        }
    }

    public class Operar:Empleado
    {
        public Operar()
        {
            String line;
            Console.Write("Ingrese nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese edad: ");
            line = Console.ReadLine();
            Edad = int.Parse(line);
            Console.Write("Ingresar sueldo: ");
            line = Console.ReadLine();
            sueldo = float.Parse(line);
            ImprimirNombreEdad();
            ImprimirSueldo();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Confeccionar una clase Persona que tenga como atributos el nombre y la edad 
             * (definir las propiedades para poder acceder a dichos atributos).
             * Definir como responsabilidad un método para imprimir.
            Plantear una segunda clase Empleado que herede de la clase Persona.
            Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo.
            Definir un objeto de la clase Persona y llamar a sus métodos y propiedades. 
            También crear un objeto de la clase Empleado y llamar a sus métodos y propiedades.
             */
            Operar operar = new Operar();

        }
    }
}
