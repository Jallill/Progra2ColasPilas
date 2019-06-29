﻿using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Implementaciones
{
    
    public class DicSimpleL : IDiccionarioSimpleTDA
    {
        class NodoClave
        {
            public int clave;
            public int valor;
            public NodoClave sigClave;
        }

        NodoClave origen;

        public void InicializarDiccionario()
        {
            origen = null;
        }

        public void Agregar(int clave, int valor)
        {
            NodoClave nc = Clave2NodoClave(clave);

            if(nc == null ) {
                nc = new NodoClave();
                nc.clave = clave;
                nc.sigClave = origen;
                origen = nc;
            }
            nc.valor = valor;
        }

        private NodoClave Clave2NodoClave(int clave)
        {
            NodoClave aux = origen;
            while(aux != null && aux.clave != clave){
                aux = aux.sigClave;
            }
            return aux;
        }

        public void Eliminar(int clave)
        {
            if(origen!= null ) {
                if(origen.clave == clave) {
                    origen = origen.sigClave;
                }
                else
                {
                    NodoClave aux = origen;
                    while(aux.sigClave != null && aux.sigClave.clave != clave){
                        aux = aux.sigClave;
                    }
                    if(aux.sigClave!= null) {
                        aux.sigClave = aux.sigClave.sigClave;
                    }
                }
            }
        }

        public int Recuperar(int clave)
        {
            NodoClave n = Clave2NodoClave(clave);
            return n.valor;
        }

        public IConjuntoTDA Claves()
        {
            IConjuntoTDA c = new ConjuntoLD();
            c.InicializarConjunto();
            NodoClave aux = origen;
            while(aux != null ){
                c.Agregar(aux.clave);
                aux = aux.sigClave;
            }
            return c;
        }
    }
}