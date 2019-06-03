using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    class Program
    {
        static void Main(string[] args)
        {

            Practica16A();

        }

        void Practica1E()
        {
            Cola cola = new Cola();
            cola.InicializarCola();
            cola.Acolar(2);
            cola.Acolar(2);
            cola.Acolar(3);
            cola.Acolar(2);
            cola.Acolar(1);

            bool capicua = Cola.EsCapicuaReduced(cola);

            Cola cola2 = new Cola();
            cola2.InicializarCola();

            cola2.Acolar(1);
            cola2.Acolar(2);
            cola2.Acolar(3);
            cola2.Acolar(3);
            cola2.Acolar(2);
            cola2.Acolar(1);

            capicua = Cola.EsCapicuaReduced(cola2);
        }

        static void Practica1F()
        {
            Cola cola = new Cola();
            cola.InicializarCola();

            cola.Acolar(2);
            cola.Acolar(2);
            cola.Acolar(3);
            cola.Acolar(2);
            cola.Acolar(1);

            Cola cola2 = new Cola();
            cola2.InicializarCola();

            cola2.Acolar(2);
            cola2.Acolar(2);
            cola2.Acolar(3);
            cola2.Acolar(2);
            cola2.Acolar(2);

            bool prueba = Cola.SonInversas(cola, cola2);
        }


        static void Practica16A()
        {
            ColaPrioridad cp1 = new ColaPrioridad();
            cp1.InicializarCola();

            cp1.AcolarPrioridad(1, 1);
            cp1.AcolarPrioridad(1, 2);
            cp1.AcolarPrioridad(3, 1);
            cp1.AcolarPrioridad(4, 4);
            cp1.AcolarPrioridad(4, 3);



            ColaPrioridad cp2 = new ColaPrioridad();
            cp2.InicializarCola();

            cp2.AcolarPrioridad(1, 1);
            cp2.AcolarPrioridad(1, 2);
            cp2.AcolarPrioridad(3, 1);
            cp2.AcolarPrioridad(4, 4);
            cp2.AcolarPrioridad(4, 3);

            bool prueba = ColaPrioridad.SonIdenticas(cp1, cp2);//ColaPrioridad.CombinarColasPrioridad(cp1, cp2);
        }
    }
}
