using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Una lista es un conjunto de nodos
 * Tiene dos campos: uno de información y un apuntador al siguiente nodo de la lista
 * Además un apuntador externo señala el primer nodo de la lista.
 * 
 * La información puede ser cualquier tipo de dato simple, estructura de datos o inclusive uno o más objetos.
 * La dirección al siguiente nodo es un puntero.
 * 
 * Según el mecanismo de inserción y extracción de nodos en la lista tenemos los siguientes tipos:

   Listas tipo pila.
   Listas tipo cola.
   Listas genéricas.


    Problema 1:
    Confeccionar una clase que administre una lista tipo pila (se debe poder insertar, extraer e imprimir los datos de la pila)
*/
namespace ListaTipoPila
{
    class Pila
    {
        class Nodo  //Para declarar un nodo debemos utilizar una clase
        {
            public int info;    //info
            public Nodo sig;    //apuntandor al siguiente nodo
        }

        private Nodo raiz; //Este puntero tiene la dirección del primer nodo de la lista.

        public Pila()   //Constructor
        {
            raiz = null;    //Raiz empieza siendo null porque no tiene ningun valor cuando se inicia.
        }

        public void Insertar(int x)
        {
            Nodo nuevo; //Creamos nuevo nodo
            nuevo = new Nodo(); //Inicializamos el nodo
            nuevo.info = x; //info guarda el valor X

            if(raiz == null)    //Si no hay ningun valor en la lista
            {
                nuevo.sig = null;   //Como no hay nada el apuntador al siguiente apunta a null
                raiz = nuevo;   //Y la raiz es el nuevo nodo con el valor X
            }
            else   //Si hay valores en la pila
            {
                nuevo.sig = raiz;   //Primero el siguiente apunta a raiz
                raiz = nuevo;       //Y despues el nuevo nodo (con valor x) es la raiz
                
            }
        }

        public int Extraer()
        {
            if(raiz != null)    //Si raiz no es null
            {
                int informacion = raiz.info;    //Guarda el valor que se va a extraer para despues retornarlo
                raiz = raiz.sig;    //Raiz pasa a ser el siguiente valor donde el apuntador marca
                return informacion; //Y se retorna el valor que se saco
            }
            else  //Si raiz es null, se retorna un valor entero maximo como codigo de error
            {
                return int.MaxValue;
            }
        }

        public void Imprimir()
        {
            Nodo reco = raiz;   //Se hace un puntero auxilar que apunte a la raiz
            Console.WriteLine("Listado de lista"); 
            while (reco != null)    //Mientras que el auxilar no sea null que se siga ejecutando
            {
                Console.Write(reco.info + " - ");   //Imprime el primer valor en info
                reco = reco.sig;    //Y el auxilar pasa a ser el siguiente en la pila
            }
            Console.WriteLine();
        }

        public bool IsNull()
        {
            Nodo reco = raiz;
            if(reco == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CantidadNodos()
        {
            Nodo reco = raiz;
            int contadorDeNodos = 0;
            if (IsNull())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                while (reco != null)
                {
                    contadorDeNodos++;
                    reco = reco.sig;
                }
                Console.WriteLine("Hay " + contadorDeNodos + " Nodos");
            }
           

        }

        public int Retornar()
        {
            if (raiz != null)
            {
                int informacion = raiz.info;
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }
        static void Main(string[] args)
        {
            Pila pila1 = new Pila();
            
             pila1.Insertar(10);
             pila1.Insertar(2);
             pila1.Imprimir();
             pila1.CantidadNodos();
             pila1.Extraer();
             pila1.Imprimir();
             pila1.CantidadNodos();
            
        }
    }
}
