namespace Library
{
    /// <summary>
    /// Al igual que la clase User, esta clase también se basa en los principios de OCP y DIP.
    /// Abstraemos lo que compone a los trabajadores y empleadores, quedando abierto a agregar
    /// fácilmente nuevas clases de menor nivel.
    /// </summary>
    public class WorkUser : User
    {
        public PersonalData PersonalData { get; private set; }
        public ContactInfo ContactInfo { get; private set; }
        public Address Address { get; private set; }
        public WorkUser(string nickname, PersonalData personalData, Address address)
        : base(nickname)
        {
            this.PersonalData = personalData;
            this.ContactInfo = this.PersonalData.ContactInfo;
            this.Address = this.PersonalData.ContactInfo.Address;
        }
    }
}