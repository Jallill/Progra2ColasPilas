using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Implementaciones
{
    public class Elemento
    {
        public int valor;
        public int prioridad;
    }

    public class ColaPrioridadAO : IColaPrioridadTDA
    {
        public Elemento[] elementos;
        public int indice;


        public void InicializarCola()
        {
            indice = 0;
            elementos = new Elemento[100];
        }

        public void AcolarPrioridad(int x, int prioridad)
        {
            int j = indice;

            // Desplaza a derecha los elementos de la cola mientras estos tengan mayor o igual prioridad que la de x

            for (; j > 0 && elementos[j - 1].prioridad >= prioridad; j--)
            {
                elementos[j] = elementos[j - 1];
            }
            elementos[j] = new Elemento();
            elementos[j].valor = x;
            elementos[j].prioridad = prioridad;
            indice++;
        }

        public bool ColaVacia()
        {
            return indice == 0;
        }

        public void Desacolar()
        {
            elementos[indice - 1] = null;
            indice--;
        }

        public int Primero()
        {
            return elementos[indice - 1].valor;
        }

        public int Prioridad()
        {
            return elementos[indice - 1].prioridad;
        }

        public int Contar()
        {
            return indice;
        }
    }
}
