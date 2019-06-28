using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Implementaciones
{
    public class ColaPI : IColaTDA
    {
        int[] a;
        int indice;


        public void InicializarCola()
        {
            a = new int[100];
            indice = 0;
        }

        public void Acolar(int x)
        {
            a[indice] = x;
            indice++;
        }

        public bool ColaVacia()
        {
            return (indice == 0);
        }

        public void Desacolar()
        {
            for (int i = 0; i < indice - 1; i++)
            {
                a[i] = a[i + 1];
            }
            indice--;
        }

        public int Primero()
        {
            return a[0];
        }

        public int Contar()
        {
            return indice;
        }
    }
}
