namespace Library
{
    public class Registereds
    {
        /// <summary>
        /// Creamos los objetos de la lista en Registereds porque es la clase
        /// encargada de guardar los objetos de tipo Employee y Employers.
        /// También, de acuerdo al principio SRP, separamos la creación del Singleton (GenericList).
        /// </summary>
        /// <typeparam name="Employee"></typeparam>
        /// <returns></returns>
        public static GenericList<Employee> Employees = new GenericList<Employee>();
        public static GenericList<Employer> Employers = new GenericList<Employer>();

        /// <summary>
        /// Tenemos un Polimorfismo en las operaciones pues no es necesario separar el método.
        /// Hacer una misma operación con dos ingresos distintos permite más fluidez.
        /// </summary>
        /// <param name="employee"></param>
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