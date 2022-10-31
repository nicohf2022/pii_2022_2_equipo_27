namespace Library
{
    public class Offer
    {
        /// <summary>
        /// Singleton instance of the Offers class.
        /// </summary>
        /// <value></value>
        public static List<Offer> Offers
        {
            get
            {
                if (Offers == null)
                {
                    Offers = new List<Offer>();
                }

                return Offers;
            }
            set
            {
            }
        }

        public Category Category { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }
        public int OfferID { get; private set; }
        public Employee OfferOwner { get; private set; }
        
        /// <summary>
        /// Constructor of the Offer class. Si se crea una oferta, se agrega a la lista de ofertas.
        /// </summary>
        /// <param name="offerID"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="category"></param>
        public Offer(int offerID, string description, int price, string category, Employee employee)
        {
            OfferID = offerID;
            Description = description + employee.NickName;
            Price = price;
            OfferOwner = employee;
            foreach (Category category1 in CategoryCatalog.categories)
            {
                if (category1.Name == category)
                {
                    category1.AddOffer(this);
                }
                else
                {
                    Console.WriteLine("La categoría no existe");
                }
            }
            Offers.Add(this);
        }
        

        /// <summary>
        ///  Method to add an offer to the list of offers.
        /// </summary>
        /// <param name="category"></param>
        public void GetOffers()
        {
            foreach (Offer offer in Offers)
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

    }
}