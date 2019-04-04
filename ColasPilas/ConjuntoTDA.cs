using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    interface ConjuntoTDA
    {

        void Agregar(int x);
        bool ConjuntoVacio();
        int Elegir();
        void InicializarConjunto();
        bool Pertenece(int x);
        void Sacar(int x);

    }
}
