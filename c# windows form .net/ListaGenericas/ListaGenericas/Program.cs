using System;
using System.Collections;
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
                        for (int i = 1; i<=pos - 2; i++)    //RECORRE 2 POSICIONES ATRAS Y GUARDA EL RECORREDOR AHI
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

        public int Extraer(int pos) //Borra el nodo de la posición (pos).
        {
            if(!Vacia())    //PRIMERO VEMOS SI HAY NODOS EN LA LISTA
            {
                int ValorExtraido = 0;  //ALMACENADOR DE VALOR EXTRAIDO
                if(pos == 1)    //SI LA POS QUE QUEREMOS SACAR ES IGUAL A 1
                {
                    raiz = raiz.sig;
                    ValorExtraido = raiz.info;
                }
                else //VEMOS SI LA POS QUE QUEREMOS EXTRAER ESTA EN EL MEDIO DEL PRIMERO POS O EN EL FINAL
                {
                    Nodo reco = raiz;
                    for(int i = 1; i <= pos - 2; i++)
                        {
                            reco = reco.sig;
                        }
                    Nodo proximo = reco.sig;
                    reco.sig = proximo.sig;
                    ValorExtraido = proximo.info;
                    
                }
                return ValorExtraido;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public void Borrar(int pos)
        {
            if (pos <= Cantidad())    //PRIMERO VEMOS SI LA POS ES MENOR O IGUAL A CANTIDAD
            {
        
                if (pos == 1)    //SI LA POS QUE QUEREMOS SACAR ES IGUAL A 1
                {
                    raiz = raiz.sig;
                }
                else
                {
                     //VEMOS SI LA POS QUE QUEREMOS EXTRAER ESTA EN EL MEDIO O EN LA ULTIMA
                    Nodo reco = raiz;
                    for (int i = 1; i <= pos - 2; i++)
                        {
                            reco = reco.sig;
                        }
                    Nodo proximo = reco.sig;
                    reco.sig = proximo.sig;
                }
                
            }
            
        }

        public void Intercambiar(int pos1, int pos2)
        {
            if (pos1 <= Cantidad() && pos2 <= Cantidad() && pos1 != pos2)
            {
                Nodo ValorPos1 = raiz;
                for(int i = 1; i < pos1; i++)
                {
                    ValorPos1 = ValorPos1.sig;
                }
                Nodo ValorPos2 = raiz;
                for (int i = 1; i < pos2; i++)
                {
                    ValorPos2 = ValorPos2.sig;
                }
                int auxiliar = ValorPos1.info;
                ValorPos1.info = ValorPos2.info;
                ValorPos2.info = auxiliar;
            }
        }

        public int Mayor()//Retorna el valor del nodo con mayor información.
        {
            
            if(!Vacia())
            {
                Nodo reco = raiz;
                int mayor = raiz.info;
                while (reco.sig != null)
                {
                    reco = reco.sig;
                    if (mayor < reco.info)
                    {
                        mayor = reco.info;
                    }
                }
                return mayor;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public int PosMayor()   //Retorna la posición del nodo con mayor información.
        {
            if(!Vacia())
            {
                Nodo reco = raiz;
                int posMayor = 1;
                int mayor = raiz.info;
                while (reco.sig != null)
                {
                    reco = reco.sig;
                    if (mayor < reco.info)
                    {
                        mayor = reco.info;
                        posMayor++;
                    }
                }
                return posMayor;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public bool Ordenada() //Debe retornar true si la lista está ordenada de menor a mayor, false en caso contrario.
        {
            if(!Vacia())
            {
                if(Cantidad() > 1)
                {
                    Nodo reco = raiz;
                    int numComparable = reco.info;
                    while(reco.sig != null)
                    {
                        reco = reco.sig;
                        if (numComparable > reco.info)
                        {
                            return false;
                        }
                        numComparable = reco.info;
                    }
                    
                }
                return true;
            }
                return false;
        }


        public bool Existe(int info) //Debe retornar true si existe la información que llega en el parámetro, false en caso contrario.
        {
            if (!Vacia())
            {
                Nodo reco = raiz;
                while(reco.sig != null)
                {
                    if (info == reco.info)
                    {
                        return true;
                    }
                    reco = reco.sig;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public void InsertarPrincipio(int info)
        {
            if (!Vacia())
            {
                Nodo siguiente = raiz.sig;
                Nodo nuevo = raiz;
                nuevo.info = info;
                nuevo.sig = siguiente;
            }
        }

        public void InsertarAlFinal(int info)
        {
            if (!Vacia())
            {
                Nodo reco = raiz;
                while(reco.sig != null)
                {
                    reco = reco.sig;
                }
                Nodo nuevo = new Nodo();
                reco.sig = nuevo;
                nuevo.info = info;
            }
        }

        public void InsertarEnPos2(int info)
        {
            if(!Vacia())
            {
                Nodo auxiliar = raiz.sig;

                Nodo nuevo = new Nodo();
                nuevo.info = info;

                raiz.sig = nuevo;
                nuevo.sig = auxiliar;
            }
        }

        public void InsertarAntePenultina(int info)
        {
            if (!Vacia())
            {
                Nodo reco = raiz;
                for(int i = 1; i < Cantidad() - 1; i++)
                {
                    reco = reco.sig;
                }
                Nodo auxiliar = reco.sig;
                Nodo nuevo = new Nodo();
                nuevo.info = info;
                reco.sig = nuevo;
                nuevo.sig = auxiliar;
            }
        }

        public void BorrarPrimerNodo()
        {
            if (!Vacia())
            {
                raiz = raiz.sig;
            }         
        }

        public void BorrarSegundoNodo()
        {
            if (!Vacia())
            {
                Nodo auxiliar = raiz.sig;
                auxiliar = auxiliar.sig;
                raiz.sig = auxiliar;
            }
        }

        public void BorrarUltimoNodo()
        {
            if (!Vacia())
            {
                Nodo reco = raiz;
                for(int i = 1; i < Cantidad() - 1; i++)
                {
                    reco = reco.sig;
                }
                reco.sig = null;
            }
        }

        public void BorrarMayor()
        {
            if (raiz != null)
            {
                Nodo reco = raiz;
                int may = raiz.info;
                while (reco != null)
                {
                    if (reco.info > may)
                    {
                        may = reco.info;
                    }
                    reco = reco.sig;
                }
                reco = raiz;
                Nodo atras = raiz;
                while (reco != null)
                {
                    if (reco.info == may)
                    {
                        if (reco == raiz)
                        {
                            raiz = raiz.sig;
                            atras = raiz;
                            reco = raiz;
                        }
                        else
                        {
                            atras.sig = reco.sig;
                            reco = reco.sig;
                        }
                    }
                    else
                    {
                        atras = reco;
                        reco = reco.sig;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            ListaGenerica lista = new ListaGenerica();
            lista.Insertar(1, 10);
            lista.Insertar(2, 20);
            lista.Insertar(3, 30);
            lista.Insertar(4, 40);
            lista.Insertar(5, 50);
            lista.Insertar(2, 80);
            lista.Insertar(1, 100);
            lista.Insertar(3, 500);
            lista.Imprimir();
            lista.BorrarMayor();
            lista.Imprimir();
        }
    }
}
