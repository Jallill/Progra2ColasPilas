using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Implementaciones
{
    public class ColaLD : IColaTDA
    {
        Nodo primero;

        Nodo ultimo;

        public void Acolar(int x)
        {
            Nodo aux = new Nodo();
            aux.info = x;
            aux.sig = null;

            //Si la cola no está vacía
            if (ultimo != null)
            {
                ultimo.sig = aux;
            }
            ultimo = aux;

            // Si la cola estaba vacía
            if (primero == null)
            {
                primero = ultimo;
            }
        }

        public bool ColaVacia()
        {
            return (ultimo == null);
        }

        public int Contar()
        {
            ColaLD aux = new ColaLD();
            aux.InicializarCola();
            aux = this;
            int cant = 0;
            while (!aux.ColaVacia())
            {
                cant++;
                aux.Desacolar();
            }
            return cant;
        }

        public void Desacolar()
        {
            primero = primero.sig;

            // Si la cola queda vacía
            if (primero == null)
            {
                ultimo = null;
            }
        }

        public void InicializarCola()
        {
            primero = null;
            ultimo = null;
        }

        public int Primero()
        {
            return primero.info;
        }

    }
}
