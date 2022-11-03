namespace Library
{
    public class GenericList<T>
    {
        public static List<T> singleton = new List<T>();
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
        public void Add(T item)
        {
            Instance.Add(item);
        }
        public void Remove(T item)
        {
            Instance.Remove(item);
        }
        public T GetByIndex(int index)
        {
            return Instance[index];
        }
        public int GetLength()
        {
            return Instance.Count();
        }
    }
}