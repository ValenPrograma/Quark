using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_de_lista_tipo_pila
{
    class Pila
    {
        class Nodo
        {
            public char simbolo;
            public Nodo sig;
        }
        private Nodo raiz;

        public Pila()
        {
            raiz = null;
        }
        
        public void Insertar(char x)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.simbolo = x;
            if(raiz == null)
            {
                nuevo.sig = null;
                raiz = nuevo;
            }
            else
            {
                nuevo.sig = raiz;
                raiz = nuevo;
            }
        }

        public char Extraer()
        {
            if(raiz != null)
            {
                char simboloExtraido;
                simboloExtraido = raiz.simbolo;
                raiz = raiz.sig;
                return simboloExtraido;
            }
            else
            {
                return char.MaxValue;
            }
        }

        public bool Vacia()
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
    }
}
