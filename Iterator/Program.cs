using System;
using Iterator.clases;
using Iterator.interfases;

class Program
{
    static void Main(string[] args)
    {
        //array con productos
        string[] lista_elementos = { "Manzana", "Banana", "Cereza" };
        //creamos una lista con los productos del array
        Lista<string> lista = new Lista<string>(lista_elementos);
        //Creamos el Iterador la la lista
        IIterator<string> iterador = lista.CrearIterator();

        //recorremos la coleccion segun el HasNext() y Next()
        while (iterador.HasNext())
        {
            //dependiendo de como querramos recorrer la coleccion en este caso una lista solo tenemos que 
            //sobrecargar el metodo Next()
            Console.WriteLine(iterador.Next());
        }
    }
}