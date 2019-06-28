using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    public interface IColaPrioridadTDA
    {
        void InicializarCola();
        void AcolarPrioridad(int x, int prioridad);
        void Desacolar();
        int Primero();
        bool ColaVacia();
        int Prioridad();
        int Contar();
    }
}
