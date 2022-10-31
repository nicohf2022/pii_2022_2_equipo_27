namespace Library
{
    public class Registereds
    {
        public GenericList<Employee> Employees = new GenericList<Employee>();
        public GenericList<Employer> Employers = new GenericList<Employer>();

        public void Register(Employee employee)
        {
            Employees.Add(employee);
        }
        public void Register(Employer employer)
        {
            Employers.Add(employer);
        }
        public void Unsubscribe(Employee employee)
        {
            Employees.Remove(employee);
        }
        public void Unsubscribe(Employer employer)
        {
            Employers.Remove(employer);
        }
    }
}