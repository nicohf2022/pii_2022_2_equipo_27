namespace Library
{
    public class Offer
    {
        public Offer(int offerID, string description, int price, Category category)
        {
            OfferID = offerID;
            Description = description;
            Price = price;
            Category = category;
        }
        public Category Category { get; private set; }
        public string Description { get; private set; }
        public int Price { get; private set; }
        public int OfferID { get; private set; }
        private GenericList<Category> CategoriesList = new GenericList<Category>();
        public GenericList<Category> GetOffersList()
        {
            return CategoriesList;
        }
        public Offer[] Offer(string category)
        {
            //Devolver Offer por Categoría
        }
        public 
        public int GetReputation(Offer offer)
        {
            //Devolver valor de reputación de la oferta
        }
    }
}