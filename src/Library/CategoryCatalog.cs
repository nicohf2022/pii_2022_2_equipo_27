using System.Collections.Generic;
namespace Library
{
    /// <summary>
    /// Definition of CategoryCatalog. The class who has the responsability to manage
    /// the categories of the services.
    /// </summary>
    public class CategoryCatalog
    {
        /// <summary>
        /// Singleton instance of the CategoryCatalog class.
        /// </summary>
        /// <value></value>
        public static List<Category> categories
        {
            get
            {
                if (categories == null)
                {
                    categories = new List<Category>();
                }

                return categories;
            }
            set
            {
            }
        }
        public CategoryCatalog()
        {
            categories = new List<Category>();
        }
    }
}