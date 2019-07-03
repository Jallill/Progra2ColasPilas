using Game.Interfaces;
using Game.Implementaciones;

namespace Game.Ejercicios
{
    public static class EDiccionario
    {

        public static IDiccionarioMultipleTDA A(IDiccionarioMultipleTDA D1, IDiccionarioMultipleTDA D2)
        {
            IConjuntoTDA C1 = D1.Claves();
            IConjuntoTDA C2 = D2.Claves();
            IDiccionarioMultipleTDA DResult = new DicMultipleA();

            DResult.InicializarDiccionario();

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

        public static IDiccionarioMultipleTDA B(IDiccionarioMultipleTDA D1, IDiccionarioMultipleTDA D2)
        {
            IConjuntoTDA C1 = D1.Claves();
            IConjuntoTDA C2 = D2.Claves();
            IDiccionarioMultipleTDA DResult = new DicMultipleA();

            DResult.InicializarDiccionario();

            int key;
            while (!C1.ConjuntoVacio())
            {
                key = C1.Elegir();

                IConjuntoTDA aux = D1.Recuperar(key);
                IConjuntoTDA aux2 = D2.Recuperar(key);
                while (!aux.ConjuntoVacio())
                {
                    int i = aux.Elegir();
                    if(!aux2.ConjuntoVacio() && aux2.Pertenece(i)) DResult.Agregar(key, i);
                    aux.Sacar(i);
                }

                C1.Sacar(key);
            }

            IConjuntoTDA Caux = DResult.Claves();

            while (!C2.ConjuntoVacio())
            {
                key = C2.Elegir();
                if(!Caux.Pertenece(key)) DResult.Agregar(key, -1);
                C2.Sacar(key);
            }

            return DResult;
        }

        public static IDiccionarioMultipleTDA C(IDiccionarioMultipleTDA D1, IDiccionarioMultipleTDA D2)
        {
            IConjuntoTDA C1 = D1.Claves();
            IConjuntoTDA C2 = D2.Claves();
            IDiccionarioMultipleTDA DResult = new DicMultipleA();

            DResult.InicializarDiccionario();

            int key;

            while (!C1.ConjuntoVacio())
            {

                key = C1.Elegir();

                if (C2.Pertenece(key))
                {
                    IConjuntoTDA aux = D1.Recuperar(key);
                    while (!aux.ConjuntoVacio())
                    {
                        int i = aux.Elegir();
                        DResult.Agregar(key, i);
                        aux.Sacar(i);
                    }
                    aux = D2.Recuperar(key);
                    while (!aux.ConjuntoVacio())
                    {
                        int i = aux.Elegir();
                        DResult.Agregar(key, i);
                        aux.Sacar(i);
                    }
                    C2.Sacar(key);
                }

                C1.Sacar(key);

            }

            return DResult;
        }
        
        public static IDiccionarioMultipleTDA D(IDiccionarioMultipleTDA D1, IDiccionarioMultipleTDA D2)
        {
            IConjuntoTDA C1 = D1.Claves();
            IConjuntoTDA C2 = D2.Claves();
            IDiccionarioMultipleTDA DResult = new DicMultipleA();

            DResult.InicializarDiccionario();

            int key;

            while (!C1.ConjuntoVacio())
            {

                key = C1.Elegir();

                if (C2.Pertenece(key))
                {
                    IConjuntoTDA aux = D1.Recuperar(key);
                    IConjuntoTDA aux2 = D2.Recuperar(key);
                    while (!aux.ConjuntoVacio())
                    {
                        int i = aux.Elegir();
                        if(aux2.Pertenece(i))
                        DResult.Agregar(key, i);
                        aux.Sacar(i);
                    }
                    C2.Sacar(key);
                }

                C1.Sacar(key);

            }

            return DResult;
        }

    }
}
