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

        public void GetOffers()
        {
            foreach (Offer offer in Offer.Offers)
            {
                Console.WriteLine(offer.Description);
            }
        }
        public void GetOffersByCategory(string category)
        {
            foreach (Category category1 in CategoryCatalog.categories)
            {
                if (category1.Name == category)
                {
                    foreach (Offer offer in category1.OffersInCategory)
                    {
                        Console.WriteLine(offer.Description);
                    }
                }
            }
        }
        public void GetOffersByUbication(string city)
        {
            foreach (Offer offer in Offer.Offers)
            {
                if (offer.OfferOwner.Address.City == city)
                {
                    Console.WriteLine(offer.Description);
                }
            }
        }
        /// <summary>
        /// Metodo para ordenar de forma descendente las ofertas por reputacion
        /// </summary>
        public void GetOffersByReputation()
        {
            List<Offer> offers = Offer.Offers;
            foreach (Offer offer in Offer.Offers)
            {
                offers.Sort((x, y) => y.OfferOwner.Reputation.CompareTo(x.OfferOwner.Reputation));
            }
        }

        private void CancelOffer(string descripcion, int offerID)
        {
            foreach (Offer offer in Offer.Offers)
            {
                if (offer.OfferID == offerID)
                {
                    Offer.Offers.Remove(offer);
                    Console.WriteLine(descripcion);
                }
            }
            foreach(Category category in CategoryCatalog.categories)
            {
                foreach(Offer offer in category.OffersInCategory)
                {
                    if (offer.OfferID == offerID)
                    {
                        category.OffersInCategory.Remove(offer);
                    }
                }
            }
        }
    }
}