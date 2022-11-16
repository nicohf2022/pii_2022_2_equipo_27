namespace Library
{
    public class Offer
    {
        /*Utilizamos el patron Singleton para que exista una lista unica que contenga todas las ofertas disponibles actualmente*/
        private static List<Offer> offers = new List<Offer>();
        /// <summary>
        /// Singleton instance of the Offers class.
        /// </summary>
        /// <value></value>
        public static List<Offer> Instance
        {
            get
            {
                return offers;
            }
        }

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
        

        /*Agregamos el constructor de la clase Offer utilizando composicion de la clase Employee*/
        public Offer(int offerid, string description, int price, string category, Employee employee)
        {
            this.OfferID = offerid;
            this.Description = description;
            this.Price = price;
            this.OfferOwner = employee;
            
            foreach (Category category1 in CategoryCatalog.Instance)
            {
                if (category1.Name == category)
                {
                    category1.AddOffer(this);
                }
                else
                {
                    Console.WriteLine("La categoría no existe.");
                }
            }
            offers.Add(this);
        }
    }
}