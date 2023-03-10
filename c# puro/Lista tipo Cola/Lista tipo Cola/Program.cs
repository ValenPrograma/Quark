using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Una lista se comporta como una cola si las inserciones las hacemos al final y las extracciones las hacemos por el frente
//de la lista. También se las llama listas FIFO (First In First Out - primero en entrar primero en salir).
namespace Lista_tipo_Cola
{
    class Cola
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }
        private Nodo raiz,fondo;

        public Cola()
        {
            raiz = null;
            fondo = null;
        }

        public bool Vacio()
        {
            if(raiz == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig = null;
            if (Vacio())
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.sig = nuevo;
                fondo = nuevo;
            }

        }

        public int Extraer()
        {
            if (!Vacio())
            {
                int informacion = raiz.info;
                if(raiz == fondo)
                {
                    raiz = null;
                    fondo = null;
                }
                else
                {
                    raiz = raiz.sig;
                }
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }

        }

        public void Imprimir()
        {
            Nodo aux = raiz;
            Console.WriteLine("La lista es: ");
            while(aux != null)
            {
                Console.Write(aux.info + " - ");
                aux = aux.sig;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Cola cola1 = new Cola();
            cola1.Insertar(5);
            cola1.Insertar(10);
            cola1.Insertar(50);
            cola1.Imprimir();
            Console.WriteLine("Extraemos uno de la cola:" + cola1.Extraer());
            cola1.Imprimir();
        }
    }
}
