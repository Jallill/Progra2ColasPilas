using System;
using Game.Ejercicios;
using Game.Interfaces;
using Game.Implementaciones;


namespace ColasPilas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*ABB abb = new ABB();
            abb.InicializarArbol();

            abb.AgregarElem(10);
            abb.AgregarElem(13);
            abb.AgregarElem(7);
            abb.AgregarElem(12);
            abb.AgregarElem(17);
            abb.AgregarElem(6);
            abb.AgregarElem(8);
            abb.AgregarElem(16);
            abb.AgregarElem(18);
            abb.AgregarElem(19);


            ABB abb2 = new ABB();
            abb2.InicializarArbol();

            abb2.AgregarElem(10);
            abb2.AgregarElem(13);
            abb2.AgregarElem(7);
            abb2.AgregarElem(12);
            abb2.AgregarElem(17);
            abb2.AgregarElem(6);
            abb2.AgregarElem(8);
            abb2.AgregarElem(16);
            abb2.AgregarElem(18);
            abb2.AgregarElem(19);

            EABB.L3(abb);
            Console.WriteLine();
            EABBI.L3(abb);*/

            DicMultipleA D1 = new DicMultipleA();
            D1.InicializarDiccionario();

            DicMultipleA D2 = new DicMultipleA();
            D2.InicializarDiccionario();

            D1.Agregar(0, 10);
            D1.Agregar(0, 20);
            D1.Agregar(0, 30);
            D1.Agregar(1, 40);
            D1.Agregar(1, 50);
            D1.Agregar(1, 60);
            D1.Agregar(2, 70);
            D1.Agregar(2, 80);
            D1.Agregar(2, 90);

            D2.Agregar(3, 40);
            D2.Agregar(3, 50);
            D2.Agregar(3, 60);
            D2.Agregar(2, 70);
            D2.Agregar(2, 80);
            D2.Agregar(2, 90);
            D2.Agregar(5, 100);
            D2.Agregar(5, 100);
            D2.Agregar(5, 1000);

            IDiccionarioMultipleTDA A = EDiccionario.A(D1, D2);
            ShowDic(A);

            Console.ReadKey();
        }

        static void ShowDic(IDiccionarioMultipleTDA dic)
        {

            IConjuntoTDA C1 = dic.Claves();
            int key;
            while (!C1.ConjuntoVacio())
            {
                key = C1.Elegir();
                IConjuntoTDA aux = dic.Recuperar(key);
                Console.Write(key + "|");

                while (!aux.ConjuntoVacio())
                {
                    int i = aux.Elegir();
                    Console.Write("[" + i + "],");
                    aux.Sacar(i);
                }
                Console.WriteLine();
                C1.Sacar(key);
            }

        }

    }
}
