using Game.Interfaces;
using System.Collections.Generic;
using System;

namespace Game.Ejercicios
{
    public static class EABBI
    {
        // Dado un elemento, determinar si está o no en un ABB
        public static bool A(IABBTDA abb, int x)
        {
            while (!abb.ArbolVacio())
            {
                if (abb.Raiz() == x) return true;
                if (abb.Raiz() > x) abb = abb.HijoIzq();
                else abb = abb.HijoDer();
            }
            return false;
        }

        // Dado un elemento, determinar si es una hoja de un ABB
        public static bool B(IABBTDA abb, int x)
        {
            while (!abb.ArbolVacio())
            {
                if (abb.Raiz() == x) return abb.HijoIzq().ArbolVacio() && abb.HijoDer().ArbolVacio();
                if (abb.Raiz() > x) abb = abb.HijoIzq();
                else abb = abb.HijoDer();
            }
            return false;
        }

        // Dado un elemento, calcular su profundidad en el ABB
        public static int C(IABBTDA abb, int x)
        {
            int i = 1;
            while (!abb.ArbolVacio())
            {
                if (abb.Raiz() == x) return i;
                if (abb.Raiz() > x) abb = abb.HijoIzq();
                else abb = abb.HijoDer();
                i++;
            }
            return -1;
        }


        // Obtener el valor del menor elemento de un ABB
        public static int D(IABBTDA abb){
            while (!abb.HijoIzq().ArbolVacio())
            {
                abb = abb.HijoIzq();
            }
            return abb.Raiz();
        }

        // Calcular la cantidad de elementos que contiene un ABB
        public static int E(IABBTDA abb)
        {
            int i = 0;
            Queue<IABBTDA> cola = new Queue<IABBTDA>();
            

            if (abb.ArbolVacio()) return i;

            cola.Enqueue(abb);

            while(cola.Count != 0)
            {
                IABBTDA temp = cola.Dequeue();
                if (!temp.ArbolVacio()) i++;

                if (!temp.HijoIzq().ArbolVacio()) cola.Enqueue(temp.HijoIzq());
                if (!temp.HijoDer().ArbolVacio()) cola.Enqueue(temp.HijoDer());
            }

            return i;
        }

        // Calcular la suma de los elementos que contiene un ABB
        public static int F(IABBTDA abb)
        {
            int count = 0;
            Queue<IABBTDA> cola = new Queue<IABBTDA>();
            
            if (abb.ArbolVacio()) return count;

            cola.Enqueue(abb);

            while (cola.Count != 0)
            {
                IABBTDA temp = cola.Dequeue();
                if (!temp.ArbolVacio()) count += temp.Raiz();

                if (!temp.HijoIzq().ArbolVacio()) cola.Enqueue(temp.HijoIzq());
                if (!temp.HijoDer().ArbolVacio()) cola.Enqueue(temp.HijoDer());
            }

            return count;
        }

        // Calcular el cantidad de hojas de un ABB
        public static int G(IABBTDA abb)
        {
            int i = 0;
            Queue<IABBTDA> cola = new Queue<IABBTDA>();


            if (abb.ArbolVacio()) return i;

            cola.Enqueue(abb);

            while (cola.Count != 0)
            {
                IABBTDA temp = cola.Dequeue();
                if (!temp.ArbolVacio() && temp.HijoIzq().ArbolVacio() && temp.HijoDer().ArbolVacio()) i++;

                if (!temp.HijoIzq().ArbolVacio()) cola.Enqueue(temp.HijoIzq());
                if (!temp.HijoDer().ArbolVacio()) cola.Enqueue(temp.HijoDer());
            }

            return i;
        }

        // Calcular la altura de un ABB
        public static int H(IABBTDA abb)
        {
            int altura = 0;
            Queue<IABBTDA> cola = new Queue<IABBTDA>();


            if (abb.ArbolVacio()) return altura;

            cola.Enqueue(abb);

            while (true)
            {
                int count = cola.Count;
                if (count == 0) return altura;
                altura++;
                while (count > 0)
                {
                    IABBTDA temp = cola.Peek();
                    cola.Dequeue();
                    if (!temp.HijoIzq().ArbolVacio())
                        cola.Enqueue(temp.HijoIzq());
                    if (!temp.HijoDer().ArbolVacio())
                        cola.Enqueue(temp.HijoDer());
                    count--;
                }
            }
        }

        // Comprobar si dos ABBs tienen la misma forma
        public static bool I(IABBTDA abb1, IABBTDA abb2)
        {
            
            Queue<IABBTDA> cola1 = new Queue<IABBTDA>();
            Queue<IABBTDA> cola2 = new Queue<IABBTDA>();

            cola1.Enqueue(abb1);
            cola2.Enqueue(abb2);

            while (cola1.Count != 0 && cola2.Count != 0)
            {
                IABBTDA temp1 = cola1.Dequeue();
                IABBTDA temp2 = cola2.Dequeue();

                if (temp1.ArbolVacio() || temp2.ArbolVacio()) return false;

                if (!temp1.HijoIzq().ArbolVacio() || !temp2.HijoIzq().ArbolVacio()) {
                    cola1.Enqueue(temp1.HijoIzq());
                    cola2.Enqueue(temp2.HijoIzq());
                }
                if (!temp1.HijoDer().ArbolVacio() || !temp2.HijoDer().ArbolVacio())
                {
                    cola1.Enqueue(temp1.HijoDer());
                    cola2.Enqueue(temp2.HijoDer());
                }
            }
            return true;
        }

        // Comprobar si dos ABBs son iguales
        public static bool J(IABBTDA abb1, IABBTDA abb2)
        {
            Queue<IABBTDA> cola1 = new Queue<IABBTDA>();
            Queue<IABBTDA> cola2 = new Queue<IABBTDA>();

            cola1.Enqueue(abb1);
            cola2.Enqueue(abb2);

            while (cola1.Count != 0 && cola2.Count != 0)
            {
                IABBTDA temp1 = cola1.Dequeue();
                IABBTDA temp2 = cola2.Dequeue();

                if (temp1.ArbolVacio() || temp2.ArbolVacio() || temp1.Raiz() != temp2.Raiz()) return false;

                if (!temp1.HijoIzq().ArbolVacio() || !temp2.HijoIzq().ArbolVacio())
                {
                    cola1.Enqueue(temp1.HijoIzq());
                    cola2.Enqueue(temp2.HijoIzq());
                }
                if (!temp1.HijoDer().ArbolVacio() || !temp2.HijoDer().ArbolVacio())
                {
                    cola1.Enqueue(temp1.HijoDer());
                    cola2.Enqueue(temp2.HijoDer());
                }
            }
            return true;
        }

        // Contar la cantidad de elementos que están en un cierto nivel N
        public static int K(IABBTDA abb, int x)
        {
            int i = 0;
            int altura = 0;
            Queue<IABBTDA> cola = new Queue<IABBTDA>();


            if (abb.ArbolVacio()) return altura;

            cola.Enqueue(abb);

            while (true)
            {
                int count = cola.Count;
                if (count == 0) return i ;
                altura++;
                while (count > 0)
                {
                    IABBTDA temp = cola.Peek();
                    cola.Dequeue();
                    if (!temp.HijoIzq().ArbolVacio())
                        cola.Enqueue(temp.HijoIzq());
                    if (!temp.HijoDer().ArbolVacio())
                        cola.Enqueue(temp.HijoDer());
                    if (altura == x) i++;
                    count--;
                }
            }
        }

        // Mostrar por pantalla todos los elementos que contiene un ABB: In-orden
        public static void L1(IABBTDA abb)
        {
            if (abb.ArbolVacio())
            {
                return;
            }

            Stack<IABBTDA> pila = new Stack<IABBTDA>();
            
            IABBTDA aux = abb;
            
            while (pila.Count > 0 || !aux.ArbolVacio())
            {
                if (!aux.ArbolVacio())
                {
                    pila.Push(aux);
                    aux = aux.HijoIzq();
                }
                else
                {
                    aux = pila.Pop();
                    Console.Write(aux.Raiz() + " ");

                    aux = aux.HijoDer();
                }
            }
        }

        // Mostrar por pantalla todos los elementos que contiene un ABB: Pre-orden
        public static void L2(IABBTDA abb)
        {
            if (abb.ArbolVacio())
            {
                return;
            }
            
            Stack<IABBTDA> pila = new Stack<IABBTDA>();
            pila.Push(abb);
            
            while (pila.Count > 0)
            {
                
                IABBTDA temp = pila.Peek();
                Console.Write(temp.Raiz() + " ");
                pila.Pop();

                if (!temp.HijoDer().ArbolVacio())
                {
                    pila.Push(temp.HijoDer());
                }
                if (!temp.HijoIzq().ArbolVacio())
                {
                    pila.Push(temp.HijoIzq());
                }
            }
        }

        // Mostrar por pantalla todos los elementos que contiene un ABB: Post-orden
        public static void L3(IABBTDA abb)
        {

            if (abb.ArbolVacio())
                return;

            Stack<IABBTDA> pila1 = new Stack<IABBTDA>();
            Stack<IABBTDA> pila2 = new Stack<IABBTDA>();
            
            pila1.Push(abb);
            
            while (pila1.Count > 0)
            {
                IABBTDA temp = pila1.Pop();
                pila2.Push(temp);
                
                if (!temp.HijoIzq().ArbolVacio())
                    pila1.Push(temp.HijoIzq());
                if (!temp.HijoDer().ArbolVacio())
                    pila1.Push(temp.HijoDer());
            }
            
            while (pila2.Count > 0)
            {
                IABBTDA temp = pila2.Pop();
                Console.Write(temp.Raiz() + " ");
            }
        }

    }
}
