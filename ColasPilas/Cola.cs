using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    class Cola
    {

        public int[] array { get; private set; }
        int index;

        public void InicializarCola()
        {
            array = new int[100];
            index = 0;
        }
        public void Acolar(int x)
        {
            if (!ColaVacia())
            {
                for (int j = index - 1; j >= 0; j--) array[j + 1] = array[j];
            }
            array[0] = x;
            index++;
        }

        public void Desacolar()
        {
            index--;
        }

        public bool ColaVacia()
        {
            return (index == 0);
        }

        public int Primero()
        {
            return array[index - 1];
        }

        public int Contar()
        {
            return index;
        }


        public static Cola InvertirCola(Cola cola)
        {
            Cola colaAux = cola;

            Cola a = new Cola();
            a.InicializarCola();

            int[] aux = new int[cola.Contar()];

            int i = 0;

            while (!colaAux.ColaVacia())
            {
                aux[i] = colaAux.Primero();
                i++;
                colaAux.Desacolar();
            }

            for (int j = aux.Length - 1; j >= 0; j--)
            {
                a.Acolar(aux[j]);
            }

            return a;
        }

        public static bool EsCapicuaReduced(Cola cola)
        {
            for (int i = 0; i <= cola.Contar() / 2; i++) if (cola.array[i] != cola.array[cola.Contar() - 1 - i]) return false;

            return true;
        }

        public static bool SonInversas(Cola C1, Cola C2)
        {
            if (C1.Contar() != C2.Contar())
            {
                return false;
            }

            for (int i = 0; i <= C1.Contar() - 1; i++)
            {
                if (C1.array[i] != C2.array[C1.Contar() - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
