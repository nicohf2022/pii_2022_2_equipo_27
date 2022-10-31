using System.Collections.Generic;
namespace Library
{
    public class GenericList<T>
    {
        //private List<T> Registereds { get; set; }
        public static List<T> singleton
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
    }
}