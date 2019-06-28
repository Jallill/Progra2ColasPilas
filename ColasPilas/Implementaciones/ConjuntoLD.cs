using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Implementaciones
{
    public class ConjuntoLD : IConjuntoTDA
    {

        Nodo c;
        int cantidad;

        public void Agregar(int x)
        {
            /* Verifica que x no este en el conjunto */

            if(!Pertenece(x)){
                Nodo aux = new Nodo();
                aux.info = x;
                aux.sig = c;
                c = aux;
                cantidad++;
            }

        }

        public bool ConjuntoVacio()
        {
            return c == null;
        }

        public int Contar()
        {
            return cantidad;
        }

        public int Elegir()
        {
            return c.info;
        }

        public void InicializarConjunto()
        {
            c = null;
        }

        public bool Pertenece(int x)
        {
            Nodo aux = c;
            while ((aux != null) && (aux.info != x))
            {
                aux = aux.sig;
            }
            return aux != null;
        }

        public void Sacar(int x)
        {
            if(c!= null){
                // si es el primer elemento de la lista
                if (c.info == x) {
                    c = c.sig;
                }
                else
                {
                    Nodo aux = c;
                    while (aux.sig != null && aux.sig.info != x)
                    {
                        aux = aux.sig;
                    }
                    if (aux.sig != null )
                    {
                        aux.sig = aux.sig.sig;
                    }
                }
            }
        }
    }
}
