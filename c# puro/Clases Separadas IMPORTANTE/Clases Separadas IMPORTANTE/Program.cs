using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Separadas_IMPORTANTE
{
    class Cliente
    {
        private String nombre;
        private float monto;

        public Cliente(String nom)
        {
            nombre = nom;
            monto = 0;
        }

        public void Depositar(float mon)
        {
            monto = mon;
        }

        public void Extraer(float mon)
        {
            monto = monto - mon;
        }

        public float RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " Tiene $" + monto);
        }
    }

    class Banco
    {

        private Cliente cliente1, cliente2, cliente3;

        public Banco()
        {
            cliente1 = new Cliente("Juan");
            cliente2 = new Cliente("Roky");
            cliente3 = new Cliente("Mario");
        }

        public void DepositarEnCliente()
        {
            cliente1.Depositar(4000);
            cliente2.Depositar(3000);
            cliente2.Extraer(1000);
        }

        public void DineroDepositado()
        {
            float total = cliente1.RetornarMonto() + cliente2.RetornarMonto() + cliente3.RetornarMonto();
            Console.WriteLine("Total depositado: " + total);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }

        static void Main(string[] args)
        {
            /*
             * Un banco tiene 3 clientes que pueden hacer depósitos y extracciones. 
              También el banco requiere que al final del día calcule la cantidad de dinero que hay depositado.
              
              
                Lo primero que hacemos es identificar las clases:
                Podemos identificar la clase Cliente y la clase Banco.
                Luego debemos definir los atributos y los métodos de cada clases.
             */

            Banco banco = new Banco();
            banco.DepositarEnCliente();
            banco.DineroDepositado();
        }
    }
       
    
}
