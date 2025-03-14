namespace Iterator.interfases
{
    public interface IIterator<T>
    {
        //Firmas de HasNext y Next
        bool HasNext();
        T Next();
    }
}