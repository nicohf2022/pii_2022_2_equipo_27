namespace Library
{
    public class PersonalData
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
//        public Rubro rubro { get; set; }
        public Address Address { get; private set; }
        public ContactInfo ContactInfo { get; private set; }
        
        public PersonalData(string name, string lastname, string phone, string email, Address address)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Address = address;
            this.ContactInfo = new ContactInfo(phone, email, address);
        }
    }
}