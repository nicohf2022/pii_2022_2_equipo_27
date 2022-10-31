namespace Library;
public class Employee : WorkUser
{
    public Employee(string nickname, PersonalData personalData, Address address)
    : base(nickname, personalData, address)
    {
        
    }
    public void CreateOffer(int offerid, string description, int price, string category, Employee employee)
    {
        Offer offer = new Offer(offerid, description, price, category, this);
    }
    private void ContactEmployer(ContactInfo employerinfo)
    {
        // Contact employer
    }
}
