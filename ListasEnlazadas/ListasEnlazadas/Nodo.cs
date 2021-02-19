using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEnlazadas
{
    class Nodo
    {
        public String dato { get; set;}
        public Nodo siguiente { get; set; } //siguiente es del mismo tipo de la clase que estamos creando

        public Nodo(String pdato)
        {
            dato = pdato;
            this.siguiente = null;
        }
    }
}
