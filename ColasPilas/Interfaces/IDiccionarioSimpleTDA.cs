using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    public interface IDiccionarioSimpleTDA
    {
        void InicializarDiccionario();
        void Agregar(int clave, int valor);
        void Eliminar(int clave);
        int Recuperar(int clave);
        IConjuntoTDA Claves();
    }
}
