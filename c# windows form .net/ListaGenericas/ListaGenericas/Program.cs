using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Una lista se comporta como genérica cuando las inserciones y extracciones se realizan en cualquier parte de la lista.*/

namespace ListaGenericas
{
    class ListaGenerica
    {
        class Nodo
        {
            public Nodo sig;
            public int info;
        }

        private Nodo raiz;

        public ListaGenerica()
        {
            raiz = null;
        }

        bool Vacia()
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
        int Cantidad()
        {
            if (!Vacia())
            {
                int cantidad = 0;
                Nodo recorredor = raiz;
                while (recorredor != null)
                {
                    cantidad++;
                    recorredor = recorredor.sig;
                }
                return cantidad;
            }
            else
            {
                return int.MaxValue;
            }
        }
        void Insertar(int pos, int x)
        {
            if(pos <= Cantidad() + 1)
            {
                Nodo Nuevo = new Nodo();
                Nuevo.info = x;
                if(pos == 1)
                {
                    Nuevo.sig = raiz;
                    raiz = Nuevo;
                }
                else
                {
                    if(pos == Cantidad() + 1) 
                    {
                        Nodo reco = raiz;
                        while(reco.sig != null)
                        {
                            reco = reco.sig;
                        }
                        reco.sig = Nuevo;
                        Nuevo.sig = null;
                    }
                    else
                    {
                        Nodo reco = raiz;
                        for (int i = 0; i<=pos - 2; i++)
                        {
                            reco = reco.sig;
                        }
                        Nodo sigueinte = reco.sig;
                        reco.sig = Nuevo;
                        Nuevo.sig = sigueinte;

                    }
                }
            }
        }

        void Extraer()
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
