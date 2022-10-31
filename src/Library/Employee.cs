namespace Library;
public class Employee : WorkUser
{
    public ContactInfo ContactInfo { get; private set; }
    public Address Address { get; private set; }

    public Employee(string nickname, PersonalData personalData, ContactInfo contactInfo)
    : base(nickname, personalData)
    {
        this.ContactInfo = contactInfo;
        this.Address = contactInfo.Address;
    }

    public void CreateOffer(int offerid, string description, int price, string category, Employee employee)
    {
        Offer offer = new Offer(offerid, description, price, category, this);
    }
}
