using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    class Cola
    {

        int[] a;
        int i;

        public void InicializarCola()
        {
            a = new int[100];
            i = 0;
        }
        public void Acolar(int x)
        {
            for (int j = i - 1; i >= 0; i--) a[j + 1] = a[j];
            a[0] = x;
            i++;
        }
        public void Desacolar()
        {
            i--;
        }

        public bool ColaVacia()
        {
            return (i == 0);
        }
        public int Primero()
        {
            return a[i - 1];
        }

    }
}
