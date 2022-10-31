namespace Library
{
    public class Administrador : User
    {
        public Administrador(string nickname)
        : base(nickname)
        {

        }


        /// <summary>
        /// Adds a category to the catalog.
        /// </summary>
        /// <param name="category"></param>
        public void AddCategory(string category)
        {
            CategoryCatalog.categories.Add(new Category(category));
        }


        /// <summary>
        ///  Removes a category from the catalog.
        /// </summary>
        /// <param name="category name"></param>
        public void RemoveCategory(string categoryname)
        {
            int categoriesnumber = CategoryCatalog.categories.Count;

            foreach (Category category in CategoryCatalog.categories)
            {
                if (category.Name == categoryname)
                {
                    CategoryCatalog.categories.Remove(category);
                }
            }
            if (CategoryCatalog.categories.Count == categoriesnumber)
            {
                Console.WriteLine("La categoría no existe");
            }
        }



        private void CancelOffer(string descripcion, int offerID)
        {
            /*Como administrador, quiero poder dar de baja ofertas de
            servicios, avisando al oferente para que de esa forma, pueda
            evitar ofertas inadecudas.*/
        }
    }
}