namespace Library
{
    public class Employer : WorkUser
    {
        public Employer(string nickname, PersonalData personalData, Address address)
        : base(nickname, personalData, address)
        {

        }
        
        private void ContactEmployee(string employeenick, string message)
        {
            foreach (Employee employee in Registereds.Employees)
            {
                if (employee.NickName == employeenick)
                {
                    MessageSender.Send(employee, message);
                }
            }
        }
    }
}