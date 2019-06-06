using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    class Conjunto
    {
        public int[] a { get; private set; }
        int cant;

        public void Agregar(int x)
        {
            if (!Pertenece(x))
            {
                a[cant] = x;
                cant++;
            }
        }
        public void Agregar(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (!Pertenece(x[i]))
                {
                    a[cant] = x[i];
                    cant++;
                }
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

        public static Conjunto Union(Conjunto a, Conjunto b)
        {

            Conjunto newConjunto = a;
            
            for(int i = 0; i <= a.cant - 1; i++)
            {
                if (!newConjunto.Pertenece(a.a[i])) newConjunto.Agregar(a.a[i]);
            }

            return newConjunto;

        }

        public static Conjunto Interseccion(Conjunto a, Conjunto b)
        {

            Conjunto newConjunto = new Conjunto();
            newConjunto.InicializarConjunto();

            Conjunto iter = a.cant > b.cant ? a : b;

            for (int i = 0; i <= iter.cant - 1; i++)
            {
                if(a.Pertenece(iter.a[i]) && b.Pertenece(iter.a[i]))
                {
                    newConjunto.Agregar(iter.a[i]);
                }
            }

            return newConjunto;

        }

        public static Conjunto Diferencia(Conjunto a, Conjunto b)
        {

            Conjunto newConjunto = new Conjunto();
            newConjunto.InicializarConjunto();

            for (int i = 0; i <= a.cant - 1; i++)
            {
                if (!b.Pertenece(a.a[i])) newConjunto.Agregar(a.a[i]);
            }

            return newConjunto;

        }
        
        public static Conjunto DiferenciaSimetricaSinExternos(Conjunto a, Conjunto b)
        {
            Conjunto newConjunto = new Conjunto();
            newConjunto.InicializarConjunto();

            for (int i = 0; i <= a.cant - 1; i++)
            {
                if (!b.Pertenece(a.a[i])) newConjunto.Agregar(a.a[i]);
            }

            for (int i = 0; i <= b.cant - 1; i++)
            {
                if (!a.Pertenece(b.a[i])) newConjunto.Agregar(b.a[i]);
            }

            return newConjunto;

        }

        public static Conjunto DiferenciaSimetricaConExternos(Conjunto a, Conjunto b)
        {

            Conjunto aux1 = new Conjunto();
            aux1.InicializarConjunto();

            aux1 = Conjunto.Diferencia(a, b);

            Conjunto aux2 = new Conjunto();
            aux2.InicializarConjunto();

            aux2 = Conjunto.Diferencia(b, a);

            Conjunto newConjunto = Conjunto.Union(aux1, aux2);

            return newConjunto;
        }

        public static bool SonIguales(Conjunto a, Conjunto b)
        {
            if (a.cant != b.cant) return false;

            for(int i = 0; i <= a.cant; i++)
            {
                if (a.a[i] != b.a[i]) return false;
            }

            return true;
        }

        public static int Cardinalidad(Conjunto conjunto)
        {
            return conjunto.cant;
        }

        public static Conjunto GenerarConjunto(Cola cola, Pila pila)
        {
            Conjunto conjunto = new Conjunto();
            conjunto.InicializarConjunto();

            for(int i = 0; i <= pila.Contar() - 1; i++)
            {
                conjunto.Agregar(pila.a[i]);
            }

            for (int i = 0; i <= cola.Contar() - 1; i++)
            {
                conjunto.Agregar(cola.array[i]);
            }

            return conjunto;
        }

    }
}
