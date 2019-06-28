using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Implementaciones
{
    public class ColaPrioridadLD : IColaPrioridadTDA
    {

        NodoPrioridad mayorPrioridad;
        int cantidad;

        public void AcolarPrioridad(int x, int prioridad)
        {
            // Creo el nuevo nodo que voy a acolar
            NodoPrioridad nuevo = new NodoPrioridad();
            nuevo.info = x;
            nuevo.prioridad = prioridad;

            // Si la cola está vacía o bien es más prioritario que el primero hay que agregarlo al principio
            if (mayorPrioridad == null || prioridad > mayorPrioridad.prioridad)
            {
                nuevo.sig = mayorPrioridad;
                mayorPrioridad = nuevo;
            }
            else
            {
                // Sabemos que mayor Prioridad no es null
                NodoPrioridad aux = mayorPrioridad;

                while (aux.sig != null && aux.sig.prioridad >= prioridad) {
                    aux = aux.sig;
                }
                nuevo.sig = aux.sig;
                aux.sig = nuevo;
            }
            cantidad++;

        }

        public bool ColaVacia()
        {
            return mayorPrioridad == null;
        }

        public int Contar()
        {
            return cantidad;
        }

        public void Desacolar()
        {
            mayorPrioridad = mayorPrioridad.sig;
        }

        public void InicializarCola()
        {
            mayorPrioridad = null;
        }

        public int Primero()
        {
            return mayorPrioridad.info;
        }

        public int Prioridad()
        {
            return mayorPrioridad.prioridad;
        }
    }
}
