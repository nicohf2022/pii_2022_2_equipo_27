namespace Library
{
    public class Category
    {
        public string Name { get; private set; }
        public IList<Offer> OffersInCategory;

        public Category(string name)
        {
            this.Name = name;
            this.OffersInCategory = new List<Offer>();
        }
        public void AddOffer(Offer offer)
        {
            OffersInCategory.Add(offer);
        }
        public void RemoveOffer(Offer offer)
        {
            OffersInCategory.Remove(offer);
        }
    }
}