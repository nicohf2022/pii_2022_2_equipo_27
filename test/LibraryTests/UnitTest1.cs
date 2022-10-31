using Library;
namespace LibraryTests;

public class Tests
{
    [Test]
    public void Test1()
    {
        CategoryCatalog categorys = new CategoryCatalog();
        var registereds = new Registereds();
        var admin = new Administrador("eladmin");

        Address useraddress0 = new Address("Calle falsa 123", "Buenos Aires Ciudad", "Buenos Aires", "Argentina", "C1425BQO");
        PersonalData userdata0 = new PersonalData("Juan", "Perez", "095101010", "JuanchoPerez@gmail.com", useraddress0);
        Employee employee0 = new Employee("Juan Pinturas", userdata0, useraddress0);

        registereds.Register(employee0);

    }
}