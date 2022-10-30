namespace Library
{
    public class Registereds
    {
        public GenericList<Employee> Employees = new GenericList<Employee>();
        public GenericList<Employer> Employers = new GenericList<Employer>();

        public void Register(Employee employee)
        {
            Employees.Register(employee);
        }
        public void Register(Employer employer)
        {
            Employers.Register(employer);
        }
        public void Unsubscribe(Employee employee)
        {
            Employees.Unsubscribe(employee);
        }
        public void Unsubscribe(Employer employer)
        {
            Employers.Unsubscribe(employer);
        }
    }
}