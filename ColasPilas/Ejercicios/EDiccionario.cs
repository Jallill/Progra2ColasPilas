using Game.Interfaces;
using Game.Implementaciones;

namespace Game.Ejercicios
{
    public static class EDiccionario
    {

        public static IDiccionarioMultipleTDA A(IDiccionarioMultipleTDA D1, IDiccionarioMultipleTDA D2)
        {
            IConjuntoTDA C1 = new ConjuntoTA();
            IConjuntoTDA C2 = new ConjuntoTA();
            IDiccionarioMultipleTDA DResult = new DicMultipleA();

            DResult.InicializarDiccionario();
            C1.InicializarConjunto();
            C2.InicializarConjunto();

            C1 = D1.Claves();
            C2 = D2.Claves();
            int key;

            while (!C1.ConjuntoVacio())
            {

                key = C1.Elegir();

                IConjuntoTDA aux = D1.Recuperar(key);

                while (!aux.ConjuntoVacio())
                {
                    int i = aux.Elegir();
                    DResult.Agregar(key, i);
                    aux.Sacar(i);
                }

                C1.Sacar(key);

                if (C2.Pertenece(key))
                {
                    aux = D2.Recuperar(key);
                    while (!aux.ConjuntoVacio())
                    {
                        int i = aux.Elegir();
                        DResult.Agregar(key, i);
                        aux.Sacar(i);
                    }
                    C2.Sacar(key);
                }

            }

            while (!C2.ConjuntoVacio())
            {
                key = C2.Elegir();

                IConjuntoTDA aux = D2.Recuperar(key);

                while (!aux.ConjuntoVacio())
                {
                    int i = aux.Elegir();
                    DResult.Agregar(key, i);
                    aux.Sacar(i);
                }

                C2.Sacar(key);
            }

            return DResult;
        }

    }
}
