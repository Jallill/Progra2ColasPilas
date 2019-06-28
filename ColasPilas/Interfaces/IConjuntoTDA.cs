using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    public interface IConjuntoTDA
    {
        void InicializarConjunto();
        bool ConjuntoVacio();
        void Agregar(int x);
        int Elegir();
        void Sacar(int x);
        bool Pertenece(int x);
        int Contar();
    }
}
