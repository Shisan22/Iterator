namespace Iterator.interfases
{
    public interface IIterableCollection<T>
    {
        // Firma de CrearIterator
        IIterator<T> CrearIterator();
    }
}