using Iterator.interfases;

namespace Iterator.clases
{
    public class ListaIterator<T> : IIterator<T>
    {
        //atributos lista y pos lista
        private Lista<T> lista;
        private int i = 0;

        //constructor recibe Lista
        public ListaIterator(Lista<T> lista)
        {
            this.lista = lista;
        }

        //Metodo HasNext esencial para el funcionamiento del ITERATOR
        public bool HasNext()
        {
            return i < lista.Count;
        }

        //Metodo Next el otro metodo esencial para el funcionamiento del ITERATOR
        public T Next()
        {
            //implementa el metodo has next para saber cuando parar y el metodo get para obtener el dato de la pos actual
            if (HasNext())
            {
                //puede 
                return lista.Get(i++);
            }
            throw new InvalidOperationException("No hay más elementos.");
        }
    }
}