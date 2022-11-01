using System.Collections.Generic;
namespace Library
{
    public class GenericList<T>
    {
        public static List<T> singleton;

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
            set
            {
            }
        }
        public void Add(T item)
        {
            singleton.Add(item);
        }
        public void Remove(T item)
        {
            singleton.Remove(item);
        }
        public T GetByIndex(int index)
        {
            return singleton[index];
        }
        public int GetLength()
        {
            return singleton.Count();
        }
    }
}