namespace Library;

/*Utiliziamos la clase Worker como clase base para la clase Employee*/


public class Employee : WorkUser
{
    public ContactInfo ContactInfo { get; private set; }
    public Address Address { get; private set; }

/*Agregamos el constructor de la clase Employee utlizando composicion de la clase PersonalData y ContactInfo*/
    public Employee(string nickname, PersonalData personalData, ContactInfo contactInfo)
    : base(nickname, personalData)
    {
        this.ContactInfo = contactInfo;
        this.Address = contactInfo.Address;
        Registereds.Register(this);
    }
/*Utilizamos el principio expert*/

    public void CreateOffer(int offerid, string description, int price, string category, Employee employee)
    {
        Offer offer = new Offer(offerid, description, price, category, this);
    }
}
