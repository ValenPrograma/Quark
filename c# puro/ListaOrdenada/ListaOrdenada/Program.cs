using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListaOrdenada
{
    class ListaOrdenada
    {
        class Nodo
        {
            public Nodo sig;
            public int info;
        }

        private Nodo raiz;

        ListaOrdenada()
        {
            raiz = null;
        }

        public void Insertar(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;

            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                if (x < raiz.info)
                {
                    nuevo.sig = raiz;
                    raiz = nuevo;
                }
                else
                {
                    Nodo reco = raiz;
                    Nodo atras = raiz;
                    while (x >= reco.info && reco.sig != null)
                    {
                        atras = reco;
                        reco = reco.sig;
                    }
                    if (x >= reco.info)
                    {
                        reco.sig = nuevo;
                    }
                    else
                    {
                        nuevo.sig = reco;
                        atras.sig = nuevo;
                    }

                }
            }

            static void Main(string[] args)
            {

            }
        }
    }
}

