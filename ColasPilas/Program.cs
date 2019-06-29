using System;
using Game.Ejercicios;
using Game.Implementaciones;


namespace ColasPilas
{
    class Program
    {
        static void Main(string[] args)
        {

            ABB abb = new ABB();
            abb.InicializarArbol();

            abb.AgregarElem(10);
            abb.AgregarElem(13);
            abb.AgregarElem(7);
            abb.AgregarElem(12);
            abb.AgregarElem(14);
            abb.AgregarElem(6);
            abb.AgregarElem(8);
            abb.AgregarElem(15);

            ABB abb2 = new ABB();
            abb2.InicializarArbol();

            abb2.AgregarElem(10);
            abb2.AgregarElem(20);
            abb2.AgregarElem(11);
            abb2.AgregarElem(12);
            abb2.AgregarElem(13);
            abb2.AgregarElem(14);


            EABB.L1(abb);
            Console.WriteLine();
            EABB.L2(abb);
            Console.WriteLine();
            EABB.L3(abb);


            Console.ReadKey();
        }

        /*static void printDictionary(Dictionary<int, ConjuntoLD> a)
        {
            foreach(KeyValuePair<int, ConjuntoLD> item in a)
            {
                Console.Write("Key: " + item.Key + " Value: [");
                for(int i = 0; i <= item.Value.cant - 1; i++)
                {
                    Console.Write(item.Value.a[i] + ", ");
                }
                Console.Write("]\n\n");
            }
            Console.Write("------------------------------------------ \n");
        }*/
    }
}
