using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Implementaciones
{
    public class PilaTF : IPilaTDA
    {
        // Pila con Tope al Final

        int[] a; // arreglo en donde se guarda la información
        int indice; // variable entera en donde se guarda la cantidad de elementos que se tienen guardados

        public void InicializarPila()
        {
            a = new int[100];
            indice = 0;
        }

        public void Apilar(int x)
        {
            a[indice] = x;
            indice++;
        }

        public void Desapilar()
        {
            indice--;
        }

        public bool PilaVacia()
        {
            return (indice == 0);
        }

        public int Tope()
        {
            return a[indice - 1];
        }
    }
}
