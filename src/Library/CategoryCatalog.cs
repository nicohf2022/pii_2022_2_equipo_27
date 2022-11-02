using System.Collections.Generic;
namespace Library
{
    /// <summary>
    /// Definition of CategoryCatalog. The class who has the responsability to manage
    /// the categories of the services.
    /// </summary>
    public class CategoryCatalog
    {
        private static List<Category> categories = new List<Category>();

        /// <summary>
        /// Singleton instance of the CategoryCatalog class.
        /// </summary>
        /// <value></value>
        public static List<Category> Instance
        {
            get
            {
                return categories;
            }
        }
        public CategoryCatalog()
        {
            categories = new List<Category>();
        }
    }
}