using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEnlazadas
{
    class ListaEnlazadaSimple
    {
        Nodo primero { get; set; }
        Nodo ultimo { get; set; }
        Nodo actual { get; set; }
        int total { set; get }
        public ListaEnlazadaSimple()
        {
            primero = ultimo = actual = null;
            total = 0;
        }
        public void agregar(String pDato)
        {
            //1. crear un nodo nuevo
            Nodo nuevo = new Nodo(pDato);
            //2. depende
            if(primero == null)//lista vacía
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else //lista no vacía
            {
                ultimo.siguiente = nuevo;
                ultimo = nuevo;
            }
        }
    }
}
