namespace Library
{
    public class GenericList<T>
    {
        //private List<T> Registereds { get; set; }
        private static List<T> singleton{ get; set; }
        
        public static List<T> Singleton
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new List<T>();
                }

                return singleton;
            }
        }
        public void Register(T item)
        {
            Singleton.Add(item);
        }
        public void Unsubscribe(T item)
        {
            Singleton.Remove(item);
        }
        public T SearchByInt(int numero)
        {
            return Singleton[numero];
        }
    }
}