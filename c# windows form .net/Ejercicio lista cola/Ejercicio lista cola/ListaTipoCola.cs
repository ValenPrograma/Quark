using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_lista_cola
{
    class Cola
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }
        private Nodo raiz, fondo;

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
        
        public void Agregar(int info)
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
                int infoExtraida = raiz.info;
                if(raiz == fondo)
                {
                    raiz = null;
                    fondo = null;
                }
                else 
                {
                    raiz = raiz.sig;   
                }
                return infoExtraida;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public int Cantidad()
        {
            int cantidad = 0;
            Nodo recorredor = raiz;
            while(recorredor != null)
            {
                cantidad++;
                recorredor = recorredor.sig;
            }
            return cantidad;
        }
    }
}
