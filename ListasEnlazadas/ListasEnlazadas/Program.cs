using System;

namespace ListasEnlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaSimple listanombres = new ListaEnlazadaSimple();
            listanombres.agregar("MIshelle");
            listanombres.agregar("Robin");
            listanombres.agregar("Edy");
        }
    }
}
