using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    interface DiccionarioMultipleTDA
    {
        void InicializarDiccionario();
        // siempre que el diccionario est´e inicializado
        void Agregar(int clave, int valor);
        // siempre que el diccionario est´e inicializado
        void Eliminar(int clave);
        // siempre que el diccionario est´e inicializado
        void EliminarValor(int clave, int valor);
        // siempre que el diccionario est´e inicializado
        Conjunto Recuperar(int clave);
        // siempre que el diccionario est´e inicializado
        Conjunto Claves();
    }
}
