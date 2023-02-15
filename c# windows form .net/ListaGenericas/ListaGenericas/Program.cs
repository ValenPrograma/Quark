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

       
        void Insertar(int pos, int x)
        {
            if(pos <= Cantidad() + 1)  //VERIFICA SI POS EXITE O SI SE PUEDE CREAR UNO MAS     
            {
                Nodo Nuevo = new Nodo();
                Nuevo.info = x;
                if(pos == 1)            //CONCLUSION SI POSS ES IGUAL A 1, HACE UN NUEVO NODO Y LO PONE AL PRINCIPIO Y EL QUE ERA
                {                       //RAIZ, LO CORRE UNO A LA DERECHA DEL NUEVO NODO PARA QUE YA NO SEA RAIZ
                    Nuevo.sig = raiz;
                    raiz = Nuevo;
                }
                else
                {
                    if(pos == Cantidad() + 1) //SI POS ES IGUAL A CANTIDAD DE NODOS  O SI SE PUEDE CREAR UNO MAS AL FINAL
                    {
                        Nodo reco = raiz;       //CREA RECORREDOR
                        while(reco.sig != null) //LO LLEVA HASTA EL FINAL DE LOS NODOS
                        {
                            reco = reco.sig;
                        }
                        reco.sig = Nuevo;   //ENLAZA EL NUEVO NODO AL FINAL
                        Nuevo.sig = null;   //CON EL APUNTADOR DEL NUEVO.SIG APUNTADO A NULL
                    }
                    else
                    {
                        Nodo reco = raiz;   //HACE UN RECORREDOR QUE EMPIEZA EN RAIZ
                        for (int i = 1; i<=pos - 2; i++)    //RECORRE 2 (APUNTADORES!!!!) ATRAS Y GUARDA EL RECORREDOR AHI
                        {
                            reco = reco.sig;
                        }
                        Nodo sigueinte = reco.sig;  //CREAMOS UN NODO AUXILIAR PARA GUARDAR EL SIGUIENTE AL RECORREDOR
                        reco.sig = Nuevo;   //AL LADO DEL APUNTADOR RECORREDOR GUARDAMOS EL NUEVO
                        Nuevo.sig = sigueinte;  //Y POR ULTIMO ENLAZAMOS AL LADO DEL NODO NUEVO, EL NODO QUE ESTABA ANTES, QUE ESTA GUARDADO EN SIGUIENTE

                    }
                }
            }
        }
       
        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                reco = reco.sig;
                cant++;
            }
            return cant;
        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            ListaGenerica lista = new ListaGenerica();
            lista.Insertar(1, 10);
            lista.Insertar(2, 20);
            lista.Insertar(3, 30);
            lista.Insertar(4, 40);
            lista.Insertar(5, 50);
            lista.Imprimir();
            lista.Insertar(4, 400);
            lista.Imprimir();

        }
    }
}
