using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    class Conjunto
    {
        int[] a;
        int cant;
        public void Agregar(int x)
        {
            if (!Pertenece(x))
            {
                a[cant] = x;
                cant++;
            }
        }
        public bool ConjuntoVacio()
        {
            return cant == 0;
        }
        public int Elegir()
        {
            return a[cant - 1];
        }
        public void InicializarConjunto()
        {
            a = new int[100];
            cant = 0;
        }
        public bool Pertenece(int x)
        {
            int i = 0;
            while (i < cant && a[i] != x)
                i++;
            return (i < cant);
        }
        public void Sacar(int x)
        {
            int i = 0;
            while (i < cant && a[i] != x) i++;
            if (i < cant)
            {
                a[i] = a[cant - 1];
                cant--;
            }
        }
    }
}
