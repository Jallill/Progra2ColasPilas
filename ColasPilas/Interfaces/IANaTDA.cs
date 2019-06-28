using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    public interface IANaTDA
    {
        int Valor();
        IANaTDA HijoMayor();
        IANaTDA HermanoSig();
        bool ArbolVacio();
        void InicializarArbol();
        void ElimHijoMConDesc(int x);
        void ElimHermSConDesc(int x);
        void CrearArbol(int r);
        void AgregarHijoM(int p, int h);
    }
}
