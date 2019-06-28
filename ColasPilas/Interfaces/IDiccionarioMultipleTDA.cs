﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    public interface IDiccionarioMultipleTDA
    {
        void InicializarDiccionario();
        void Agregar(int clave, int valor);
        void Eliminar(int clave);
        void EliminarValor(int clave, int valor);
        IConjuntoTDA Recuperar(int clave);
        IConjuntoTDA Claves();
    }
}
