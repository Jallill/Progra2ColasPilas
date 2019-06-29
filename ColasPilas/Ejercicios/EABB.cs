using Game.Interfaces;
using System;

namespace Game.Ejercicios

{
    public static class EABB
    {

        public static bool A(IABBTDA abb, int x)
        {
            if (abb.Raiz() == x) return true;
            if (!abb.HijoIzq().ArbolVacio()) return A(abb.HijoIzq(), x);
            else if (!abb.HijoDer().ArbolVacio()) return A(abb.HijoDer(), x);
            else return false;
        }

        public static bool B(IABBTDA abb, int x)
        {
            if (abb.Raiz() == x && abb.HijoDer().ArbolVacio() && abb.HijoIzq().ArbolVacio()) return true;
            if (!abb.HijoIzq().ArbolVacio()) return B(abb.HijoIzq(), x);
            else if (!abb.HijoDer().ArbolVacio()) return B(abb.HijoDer(), x);
            else return false;
        }

        public static int C(IABBTDA abb, int x)
        {
            if (abb.Raiz() == x) return 1;
            if (!abb.HijoIzq().ArbolVacio()) return C(abb.HijoIzq(), x) + 1;
            else if (!abb.HijoDer().ArbolVacio()) return C(abb.HijoDer(), x) + 1;
            return -1;
        }

        public static int D(IABBTDA abb, int x = int.MaxValue)
        {
            if (abb.Raiz() < x) x = abb.Raiz();
            if (!abb.HijoIzq().ArbolVacio()) return D(abb.HijoIzq(), x);
            else if (!abb.HijoDer().ArbolVacio()) return D(abb.HijoDer(), x);
            return x;
        }

        public static int E(IABBTDA abb)
        {
            int cont = 1;

            if (!abb.HijoIzq().ArbolVacio()) cont += E(abb.HijoIzq());
            if (!abb.HijoDer().ArbolVacio()) cont += E(abb.HijoDer());

            return cont;
        }

        public static int F(IABBTDA abb)
        {
            int cont = abb.Raiz();

            if (!abb.HijoIzq().ArbolVacio()) cont += F(abb.HijoIzq());
            if (!abb.HijoDer().ArbolVacio()) cont += F(abb.HijoDer());

            return cont;
        }

        public static int G(IABBTDA abb)
        {
            int cont = 0;
            if (abb.HijoIzq().ArbolVacio() && abb.HijoDer().ArbolVacio()) cont++;
            if (!abb.HijoIzq().ArbolVacio()) cont += G(abb.HijoIzq());
            if (!abb.HijoDer().ArbolVacio()) cont += G(abb.HijoDer());
            return cont;
        }

        public static int H(IABBTDA abb, int a = 1, int alt = 1)
        {
            if (!abb.HijoIzq().ArbolVacio()) alt = H(abb.HijoIzq(), a + 1, alt);
            if (!abb.HijoDer().ArbolVacio()) alt = H(abb.HijoDer(), a + 1, alt);
            if (a > alt) alt = a;

            return alt;
        }

        public static bool I(IABBTDA abb1, IABBTDA abb2)
        {
            if (abb1.ArbolVacio() && abb2.ArbolVacio()) return true;
            if (!abb1.ArbolVacio() && !abb2.ArbolVacio()) return I(abb1.HijoIzq(), abb2.HijoIzq()) && I(abb1.HijoDer(), abb2.HijoDer());
            return false;
        }

        public static bool J(IABBTDA abb1, IABBTDA abb2)
        {
            if (abb1.ArbolVacio() && abb2.ArbolVacio()) return true;
            if (!abb1.ArbolVacio() & !abb2.ArbolVacio() & abb1.Raiz() == abb2.Raiz()) return I(abb1.HijoIzq(), abb2.HijoIzq()) && I(abb1.HijoDer(), abb2.HijoDer());
            return false;
        }

        public static int K(IABBTDA abb, int x, int a = 1)
        {
            int cont = 0;
            if (a == x) cont++;
            if (!abb.HijoIzq().ArbolVacio()) cont += K(abb.HijoIzq(), x, a+1 );
            if (!abb.HijoDer().ArbolVacio()) cont += K(abb.HijoDer(), x, a+1 );
            return cont;
        }

        public static void L1(IABBTDA abb)
        {
            if (abb.ArbolVacio()) return;

            L1(abb.HijoIzq());

            Console.Write(abb.Raiz() + " ");

            L1(abb.HijoDer());
        }

        public static void L2(IABBTDA abb)
        {
            if (abb.ArbolVacio()) return;
            Console.Write(abb.Raiz() + " ");

            L2(abb.HijoIzq());

            L2(abb.HijoDer());
        }

        public static void L3(IABBTDA abb)
        {
            if (abb.ArbolVacio()) return;

            L3(abb.HijoIzq());

            L3(abb.HijoDer());

            Console.Write(abb.Raiz() + " ");
        }
    }
}
