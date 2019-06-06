using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    interface ColaTDA
    {

        void InicializarCola();
        // siempre que la cola est´e inicializada
        void Acolar( int x );
        // siempre que la cola est´e inicializada y no est´e vac´ıa
        void Desacolar();
        // siempre que la cola est´e inicializada
        bool ColaVacia();
        // siempre que la cola est´e inicializada y no est´e vac´ıa
        int Primero();

    }
}
