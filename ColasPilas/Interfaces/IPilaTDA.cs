using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    public interface IPilaTDA
    {
        void InicializarPila();
        void Apilar(int x);
        void Desapilar();
        bool PilaVacia();
        int Tope();
    }
}
