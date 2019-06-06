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

        /// <summary>
        /// Elimino todos los elementos repetidos en la pila.
        /// </summary>
        /// <returns>El primer valor que se ingreso que se repetia.</returns>
        public int EliminarRepeticiones()
        {
            int[] aux = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                aux[i] = a[i];
            }
            int primeroEncontrado = 0;
            //Recorro ambos arrays y elimino de aux los valores repetidos.
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    for (int j = 0; j < aux.Length; j++)
                    {
                        if (a[i] == aux[j])
                        {
                            if (primeroEncontrado == 0)
                            {
                                primeroEncontrado = aux[j];
                            }
                            aux[j] = 0;
                        }
                    }
                }
            }
            //Reinicio a y le agrego los valores de aux.
            InicializarPila();
            for (int i = 0; i < aux.Length; i++)
            {
                Apilar(aux[i]);
            }
            return primeroEncontrado;
        }

        /// <summary>
        /// Agrego a un conjunto todos los elementos repetidos en una pila.
        /// </summary>
        /// <returns>Conjunto con los elementos repetidos.</returns>
        public Conjunto ConjuntoRepetidos()
        {
            Conjunto c = new Conjunto();
            int[] aux = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                aux[i] = a[i];
            }
            //Recorro ambos arrays y elimino de aux los valores repetidos.
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    for (int j = 0; j < aux.Length; j++)
                    {
                        if (a[i] == aux[j])
                        {
                            c.Agregar(a[i]);
                        }
                    }
                }
            }
            return c;
        }
    }
}
