namespace Library
{
    public class Employer : WorkUser
    {
        public Employer(string nickname, PersonalData personalData, Address address)
        : base(nickname, personalData, address)
        {

        }
        
        private void ContactEmployee(ContactInfo employeeinfo)
        {
            // Contact employer
        }
    }
}