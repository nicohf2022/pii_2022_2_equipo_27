namespace Library
{
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