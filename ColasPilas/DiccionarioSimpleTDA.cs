using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    interface DiccionarioSimpleTDA
    {
        void InicializarDiccionario();
        void Agregar(int clave, int valor);
        int Clave2Indice(int clave);
        void Eliminar(int clave);
        int Recuperar(int clave);
        Conjunto Claves();
    }
}
