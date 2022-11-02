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
            CategoryCatalog.Instance.Add(new Category(category));
        }


        /// <summary>
        ///  Removes a category from the catalog.
        /// </summary>
        /// <param name="category name"></param>
        public void RemoveCategory(string categoryname)
        {
            int categoriesnumber = CategoryCatalog.Instance.Count;

            foreach (Category category in CategoryCatalog.Instance)
            {
                if (category.Name == categoryname)
                {
                    CategoryCatalog.Instance.Remove(category);
                }
            }
            if (CategoryCatalog.Instance.Count == categoriesnumber)
            {
                Console.WriteLine("La categoría no existe");
            }
        }

        public string GetOffers()
        {
            string offers = "";
            if (Offer.Instance.Count == 1)
            {
                return Offer.Instance[0].Description;
            }
            foreach (Offer offer in Offer.Instance)
            {
               offers += offer.Description;
            }
            return offers;
        }
        public void GetOffersByCategory(string category)
        {
            foreach (Category category1 in CategoryCatalog.Instance)
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
        /// <summary>
        /// method that returns the list of offers of an exact ubication (city)
        /// </summary>
        /// <param name="city"></param>
        /// <returns>string that containg offers description of the ubication</returns>
        public string GetOffersByUbication(string city)
        {
            string offers = "";
            if (Offer.Instance.Count == 1)
            {
                return Offer.Instance[0].Description;
            }
            foreach (Offer offer in Offer.Instance)
            {
                if (offer.OfferOwner.Address.City == city)
                {
                    offers += offer.Description;
                }
            }
            return offers;
        }
        /// <summary>
        /// Metodo para ordenar de forma descendente las ofertas por reputacion
        /// </summary>
        public string GetOffersByReputation()
        {
            string offertxt = "";
            List<Offer> offers = Offer.Instance;
            offers = offers.OrderByDescending(o => o.OfferOwner.Reputation).ToList();
            if (offers.Count == 1)
            {
                return offers[0].Description;
            }
            for(int i = 0; i < offers.Count; i++)
            {
                offertxt += offers[i].Description;
            }
            return offertxt;
        }

        public void CancelOffer(string descripcion, int offerID)
        {
            for(int i = 0; i < Offer.Instance.Count; i++)
            {
                if (Offer.Instance[i].OfferID == offerID)
                {
                    Offer.Instance.Remove(Offer.Instance[i]);
                    Console.WriteLine("La oferta se ha cancelado");
                }
            }
            for(int i = 0; i < CategoryCatalog.Instance.Count; i++)
            {
                for(int j = 0; j < CategoryCatalog.Instance[i].OffersInCategory.Count; j++)
                {
                    if (CategoryCatalog.Instance[i].OffersInCategory[j].OfferID == offerID)
                    {
                        CategoryCatalog.Instance[i].OffersInCategory.Remove(CategoryCatalog.Instance[i].OffersInCategory[j]);
                        Console.WriteLine("La oferta se ha cancelado");
                    }
                }
            }
            foreach(Category category in CategoryCatalog.Instance)
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