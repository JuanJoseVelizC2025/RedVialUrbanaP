using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVialUrbanaP.Estructuras
{
    public class NodoLista<T>
    {
        public T Dato { get; set; }
        public NodoLista<T> Siguiente { get; set; }

        public NodoLista(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    public class ListaSimple<T>
    {
        private NodoLista<T> cabeza;

        public ListaSimple()
        {
            cabeza = null;
        }

        public void AgregarAlFinal(T dato)
        {
            NodoLista<T> nuevo = new NodoLista<T>(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoLista<T> temp = cabeza;
                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
            }
        }

        public NodoLista<T> ObtenerCabeza()
        {
            return cabeza;
        }

        public bool EstaVacia()
        {
            return cabeza == null;
        }
    }
}
