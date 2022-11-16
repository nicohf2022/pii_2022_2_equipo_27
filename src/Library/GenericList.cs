namespace Library
{
    /*Clase generica que permite crear listas de cualquier tipo de objeto implementando el patron Singleton*/
    public class GenericList<T>
    {
        private static List<T> singleton = new List<T>();
        public static List<T> Instance
        {
            get
            {
                return singleton;
            }
            set
            {
                singleton = value;
            }
        }

        /*Agregado por Expert*/
        public void Add(T item)
        {
            Instance.Add(item);
        }
        /*Agregado por Expert*/
        public void Remove(T item)
        {
            Instance.Remove(item);
        }
        /*Agregado por Expert*/
        public T GetByIndex(int index)
        {
            return Instance[index];
        }
        /*Agregado por Expert*/
        public int GetLength()
        {
            return Instance.Count();
        }
    }
}