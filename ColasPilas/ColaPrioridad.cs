using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{

    class Elemento
    {
        public int valor;
        public int prioridad;
    }

    class ColaPrioridad : ColaPrioridadTDA
    {

        Elemento[] elementos ;
        int indice;

        public void InicializarCola()
        {
            indice = 0;
            elementos = new Elemento[100];
            
        }
        public void AcolarPrioridad(int x, int prioridad)
        {
            // desplaza a derecha los elementos de la cola mientras
            // estos tengan mayor o igual prioridad que la de x
            int j = indice;
            for (; j > 0 && elementos[j - 1].prioridad >= prioridad; j--)
            {
                elementos[j] = elementos[j - 1];

            }
            elementos[j] = new Elemento();
            elementos[j].valor = x;
            elementos[j].prioridad = prioridad;
            indice++;

        }

        public void Desacolar()
        {
            indice--;
        }

        public int Primero()
        {
            return elementos[indice - 1].valor;
        }

        public bool ColaVacia()
        {
            return (indice == 0);
        }

        public int Prioridad()
        {
            return elementos[indice - 1].prioridad;
        }

        public static ColaPrioridad CombinarColasPrioridad(ColaPrioridad C1, ColaPrioridad C2)
        {
            ColaPrioridad aux = new ColaPrioridad();
            aux.InicializarCola();

            for (int i = 0; i <= C1.indice - 1; i++)
            {
                aux.AcolarPrioridad(C1.elementos[i].valor, C1.elementos[i].prioridad);
            }

            for (int i = 0; i <= C2.indice - 1; i++)
            {
                aux.AcolarPrioridad(C2.elementos[i].valor, C2.elementos[i].prioridad);
            }

            return aux;
        }

        public static bool SonIdenticas(ColaPrioridad C1, ColaPrioridad C2)
        {
            if(C1.indice != C2.indice) { return false; }
            for(int i = 0; i <= C1.indice - 1; i++)
            {
                if(C1.elementos[i].valor != C2.elementos[i].valor || C1.elementos[i].prioridad != C2.elementos[i].prioridad)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
