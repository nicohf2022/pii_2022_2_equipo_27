namespace Library
{
    public class Registereds
    {
        public static GenericList<Employee> Employees = new GenericList<Employee>();
        public static GenericList<Employer> Employers = new GenericList<Employer>();

        public static void Register(Employee employee)
        {
            Employees.Register(employee);
        }
        public static void Register(Employer employer)
        {
            Employers.Register(employer);
        }
        public static void Unsubscribe(Employee employee)
        {
            Employees.Unsubscribe(employee);
        }
        public static void Unsubscribe(Employer employer)
        {
            Employers.Unsubscribe(employer);
        }
        public static Employer GetEmployerByIndex(int index)
        {
            return Employers.SearchByInt(index);
        }
    }
}