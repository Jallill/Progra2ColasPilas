using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Implementaciones
{
    public class PilaLD : IPilaTDA
    {
        Nodo primero;

        public void Apilar(int x)
        {
            Nodo aux = new Nodo();
            aux.info = x;
            aux.sig = primero;
            primero = aux;
        }

        public void Desapilar()
        {
            primero = primero.sig;
        }

        public void InicializarPila()
        {
            primero = null;
        }

        public bool PilaVacia()
        {
            return primero == null;
        }

        public int Tope()
        {
            return primero.info;
        }
    }
}
