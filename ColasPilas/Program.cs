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
            EABBI.L3(abb);

            Console.ReadKey();
        }
    }
}
