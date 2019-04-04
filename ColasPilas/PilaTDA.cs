using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    interface PilaTDA
    {

        void InicializarPila();
        void Apilar( int x);
        void Desapilar();
        bool PilaVacia();
        int Tope();


    }
}
