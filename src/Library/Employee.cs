namespace Library;
public class Employee : WorkUser
{
    public Employee(string nickname, PersonalData personalData, Address address)
    : base(nickname, personalData, address)
    {
        
    }
    private void OfferService(Category category, string description, int price)
    {
        // Offer service to customer
    }
    private void ContactEmployer(ContactInfo employerinfo)
    {
        // Contact employer
    }
}
