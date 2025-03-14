using Iterator.interfases;

namespace Iterator.clases
{
    public class Lista<T> : IIterableCollection<T>
    {
        //atributo elementos
        private T[] elementos;

        //constructor Lista recibe elementos
        public Lista(T[] elementos)
        {
            this.elementos = elementos;
        }

        //metodo crearIteraor
        public IIterator<T> CrearIterator()
        {
            return new ListaIterator<T>(this);
        }

        //contamos num elementos de la lista
        public int Count => elementos.Length;

        //obtener el elemento de la pos i
        public T Get(int i)
        {
            return elementos[i];
        }
    }
}