namespace Library
{
    public class ContactInfo
    {
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public Address Address { get; private set; }
        

        public ContactInfo(string phone, string email, Address address)
        {
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
        }
    }
}