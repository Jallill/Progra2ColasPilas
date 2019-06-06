using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasPilas
{
    class DiccionarioMultiple
    {
        public class NodoClave
        {
            public int clave;
            public NodoValor valores;
            public NodoClave sigClave;
        }
        public class NodoValor
        {
            public int valor;
            public NodoValor sigValor;
        }
        NodoClave origen;
        public void InicializarDiccionario()
        {
            origen = null;
        }
        public void Agregar(int clave, int valor)
        {
            NodoClave nc = Clave2NodoClave(clave);
            if (nc == null)
            {
            }
            nc = new NodoClave();
            nc.clave = clave;
            nc.sigClave = origen;
            origen = nc;

            NodoValor aux = nc.valores;
            while (aux != null && aux.valor != valor)
            {
                aux = aux.sigValor;
            }
            if (aux == null)
            {
                NodoValor nv = new NodoValor();
                nv.valor = valor;
                nv.sigValor = nc.valores;
                nc.valores = nv;
            }
        }
        private NodoClave Clave2NodoClave(int clave)
        {
            NodoClave aux = origen;
            while (aux != null && aux.clave != clave)
            {
                aux = aux.sigClave;
            }
            return aux;
        }
        public void EliminarValor(int clave, int valor)
        {
            if (origen != null)
            {
                if (origen.clave == clave)
                {
                    EliminarValorEnNodo(origen, valor);
                    if (origen.valores == null)
                    {
                        origen = origen.sigClave;
                    }
                }
                else
                {
                    NodoClave aux = origen;
                    while (aux.sigClave != null && aux.sigClave.clave
                    != clave)
                    {
                        aux = aux.sigClave;
                    }
                    if (aux.sigClave != null)
                    {
                        EliminarValorEnNodo(aux.sigClave, valor);
                        if (aux.sigClave.valores == null)
                        {
                            aux.sigClave = aux.sigClave.sigClave;
                        }
                    }
                }
            }
        }
        private void EliminarValorEnNodo(NodoClave nodo, int valor)
        {
            if (nodo.valores != null)
            {
                if (nodo.valores.valor == valor)
                {
                    nodo.valores = nodo.valores.sigValor;
                }
                else
                {
                    NodoValor aux = nodo.valores;
                    while (aux.sigValor != null && aux.sigValor.valor
                    != valor)
                    {
                        aux = aux.sigValor;
                    }
                    if (aux.sigValor != null)
                    {
                        aux.sigValor = aux.sigValor.sigValor;
                    }
                }
            }
        }
        public void Eliminar(int clave)
        {
            if (origen != null)
            {
                if (origen.clave == clave)
                {
                    origen = origen.sigClave;
                }
                else
                {
                    NodoClave aux = origen;
                    while (aux.sigClave != null && aux.sigClave.clave
                    != clave)
                    {
                        aux = aux.sigClave;
                    }
                    if (aux.sigClave != null)
                    {
                        aux.sigClave = aux.sigClave.sigClave;
                    }
                }
            }
        }
        public Conjunto Recuperar(int clave)
        {
            NodoClave n = Clave2NodoClave(clave);
            Conjunto c = new Conjunto();
            c.InicializarConjunto();
            if (n != null)
            {
                NodoValor aux = n.valores;
                while (aux != null)
                {
                    c.Agregar(aux.valor);
                    aux = aux.sigValor;
                }
            }
            return c;
        }
        public Conjunto Claves()
        {
            Conjunto c = new Conjunto();
            c.InicializarConjunto();
            NodoClave aux = origen;
            while (aux != null)
            {
                c.Agregar(aux.clave);
                aux = aux.sigClave;
            }
            return c;
        }

        /// <summary>
        /// Hago la union de los 2 diccionarios, completamente.
        /// </summary>
        /// <param name="D1"></param>
        /// <param name="D2"></param>
        /// <returns></returns>
        public static Dictionary<int, Conjunto> Union(Dictionary<int, Conjunto> D1, Dictionary<int, Conjunto> D2)
        {
            Dictionary<int, Conjunto> resultado = new Dictionary<int, Conjunto>();

            foreach (KeyValuePair<int, Conjunto> item in D1)
            {
                Conjunto aux = new Conjunto();
                aux.InicializarConjunto();
                //Engine.Debug("Se inicializo un conjunto con indice " + aux.Array.Length);
                aux.Agregar(item.Value.a);

                resultado.Add(item.Key, item.Value);
                //resultado[item.Key].InicializarConjunto(D1[item.Key].Array.Length + D2[item.Key].Array.Length);
            }

            foreach (KeyValuePair<int, Conjunto> item in D2)
            {
                resultado[item.Key].Agregar(item.Value.a);
            }
            return resultado;
        }

        /// <summary>
        /// Hago la union de los 2 diccionarios, solo de los elementos coincidentes en cada conjunto.
        /// </summary>
        /// <param name="D1"></param>
        /// <param name="D2"></param>
        /// <returns></returns>
        public static Dictionary<int, Conjunto> UnionClavesCoincidentes(Dictionary<int, Conjunto> D1, Dictionary<int, Conjunto> D2)
        {
            Dictionary<int, Conjunto> resultado = new Dictionary<int, Conjunto>();

            foreach (KeyValuePair<int, Conjunto> item in D1)
            {
                Conjunto aux = new Conjunto();
                aux.InicializarConjunto();
                aux.Agregar(item.Value.a);

                resultado.Add(item.Key, item.Value);
            }

            foreach (KeyValuePair<int, Conjunto> item in D2)
            {
                resultado[item.Key].Agregar(item.Value.a);
            }
            return resultado;
        }

        /// <summary>
        /// Hago la union de los 2 diccionarios, completamente, de los elementos que comparten clave.
        /// </summary>
        /// <param name="D1"></param>
        /// <param name="D2"></param>
        /// <returns></returns>
        public static Dictionary<int, Conjunto> UnionClavesComunes(Dictionary<int, Conjunto> D1, Dictionary<int, Conjunto> D2)
        {
            Dictionary<int, Conjunto> resultado = new Dictionary<int, Conjunto>();

            foreach (KeyValuePair<int, Conjunto> item in D1)
            {
                Conjunto aux = new Conjunto();
                aux.InicializarConjunto();
                aux.Agregar(item.Value.a);

                resultado.Add(item.Key, item.Value);
            }

            foreach (KeyValuePair<int, Conjunto> item in D2)
            {
                resultado[item.Key].Agregar(item.Value.a);
            }
            return resultado;
        }

        /// <summary>
        /// Hago la union de los 2 diccionarios, completamente de los elementos coincidentes que comparten clave.
        /// </summary>
        /// <param name="D1"></param>
        /// <param name="D2"></param>
        /// <returns></returns>
        public static Dictionary<int, Conjunto> UnionClavesComunesCoincidentes(Dictionary<int, Conjunto> D1, Dictionary<int, Conjunto> D2)
        {
            Dictionary<int, Conjunto> resultado = new Dictionary<int, Conjunto>();

            foreach (KeyValuePair<int, Conjunto> item in D1)
            {
                Conjunto aux = new Conjunto();
                aux.InicializarConjunto();
                aux.Agregar(item.Value.a);

                resultado.Add(item.Key, item.Value);
            }

            foreach (KeyValuePair<int, Conjunto> item in D2)
            {
                resultado[item.Key].Agregar(item.Value.a);
            }
            return resultado;
        }

    }
}
