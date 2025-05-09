using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedVialUrbanaP.Estructuras
{
    public class NodoDoble<T>
    {
        public T Dato { get; set; }
        public NodoDoble<T> Siguiente { get; set; }
        public NodoDoble<T> Anterior { get; set; }

        public NodoDoble(T dato)
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }
    }

    public class ListaDoble<T>
    {
        private NodoDoble<T> cabeza;
        private NodoDoble<T> cola;

        public ListaDoble()
        {
            cabeza = null;
            cola = null;
        }

        public void AgregarAlFinal(T dato)
        {
            NodoDoble<T> nuevo = new NodoDoble<T>(dato);
            if (cabeza == null)
            {
                cabeza = cola = nuevo;
            }
            else
            {
                cola.Siguiente = nuevo;
                nuevo.Anterior = cola;
                cola = nuevo;
            }
        }

        public void AgregarAlInicio(T dato)
        {
            NodoDoble<T> nuevo = new NodoDoble<T>(dato);
            if (cabeza == null)
            {
                cabeza = cola = nuevo;
            }
            else
            {
                nuevo.Siguiente = cabeza;
                cabeza.Anterior = nuevo;
                cabeza = nuevo;
            }
        }

        public bool EstaVacia()
        {
            return cabeza == null;
        }

        public NodoDoble<T> ObtenerCabeza()
        {
            return cabeza;
        }

        public NodoDoble<T> ObtenerCola()
        {
            return cola;
        }
    }
}
