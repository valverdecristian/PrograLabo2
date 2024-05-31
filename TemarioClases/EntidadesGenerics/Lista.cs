namespace EntidadesGenerics
{
    // esta clase es generica porque tiene <> y adentro un identificador del tipo 
    public class Lista<T> // se empieza por la T
    {
        // cuando invoque a esta clase con el tipo declarado, la T se va a reemplazar por el parametro especificado
        
        // atributo del tipo T
        T[] lista;

        // metodo que recibe un elemento del tipo T
        public void Add(T item)
        {

        }

        // metodo que devuelve un elemento del tipo T
        public T GetElement(int index)
        {
            return T;
        }
    }
}