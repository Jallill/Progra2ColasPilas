using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    class Pila : PilaTDA
    {
        int[] a;
        int i;

        public void InicializarPila()
        {
            a = new int[100];
            i = 0;
        }
        public void Apilar( int x)
        {
            a[i] = x;
            i++;
        }
        public void Desapilar()
        {
            i --;
        }
        public bool PilaVacia()
        {
            return (i == 0);
        }
        public int Tope()
        {
            return a[i - 1];
        }


    }
}
