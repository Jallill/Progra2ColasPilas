using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    interface ColaPrioridadTDA
    {

        void InicializarCola();
        void AcolarPrioridad(int x, int prioridad);
        void Desacolar();
        int Primero();
        bool ColaVacia();
        int Prioridad();

    }
}
