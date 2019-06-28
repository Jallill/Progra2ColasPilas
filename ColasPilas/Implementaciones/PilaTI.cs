using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Implementaciones
{
    public class PilaTI : IPilaTDA
    {
        // Pila con Tope al Inicio

        int[] a; // Arreglo en donde se guarda la información
        int indice; // Variable entera en donde se guarda la cantidad de elementos que se tienen guardados

        public void InicializarPila()
        {
            a = new int[100];
            indice = 0;
        }

        public void Apilar(int x)
        {
            for (int i = indice - 1; i >= 0; i--)
            {
                a[i + 1] = a[i];
            }
            a[0] = x;
            indice++;
        }

        public void Desapilar()
        {
            for (int i = 0; i < indice; i++)
            {
                a[i] = a[i + 1];
            }
            indice--;
        }

        public bool PilaVacia()
        {
            return (indice == 0);
        }

        public int Tope()
        {
            return a[0];
        }
    }
}
