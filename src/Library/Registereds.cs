namespace Library
{
    /// <summary>
    /// Creamos los objetos de la lista en Registereds porque es la clase
    /// encargada de guardar los objetos de tipo Employee y Employers.
    /// También, de acuerdo al principio SRP, separamos la creación del Singleton (GenericList).
    /// 
    /// Tenemos un Polimorfismo en las operaciones pues no es necesario separar el método.
    /// Hacer una misma operación con dos ingresos distintos permite más fluidez.
    /// </summary>
    public class Registereds
    {
        public static GenericList<Employee> Employees = new GenericList<Employee>();
        public static GenericList<Employer> Employers = new GenericList<Employer>();

/*Utilizamos el principio Expert*/
        public static void Register(Employee employee)
        {
            Employees.Add(employee);
        }
/*Agregado por Expert*/
        public static void Register(Employer employer)
        {
            Employers.Add(employer);
        }

/*Agregado por Expert*/
        public static void Unsubscribe(Employee employee)
        {
            Employees.Remove(employee);
        }
        public static void Unsubscribe(Employer employer)
        {
            Employers.Remove(employer);
        }

/*Agregado por Expert*/
        public static Employer GetEmployerByIndex(int index)
        {
            return Employers.GetByIndex(index);
        }
/*Agregado por Expert*/
        public static Employee GetEmployeeByIndex(int index)
        {
            return Employees.GetByIndex(index);
        }
    }
}