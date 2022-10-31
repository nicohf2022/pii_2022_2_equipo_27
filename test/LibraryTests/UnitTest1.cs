using Library;
namespace LibraryTests;

public class Tests
{
    [Test]
    public void Test4()
    {
        var categorys = new CategoryCatalog();
        var registereds = new Registereds();
        var admin = new Administrador("eladmin");

        Address useraddress0 = new Address("Calle falsa 123", "Buenos Aires Ciudad", "Buenos Aires", "Argentina", "C1425BQO");
        PersonalData userdata0 = new PersonalData("Juan", "Perez", "095101010", "JuanchoPerez@gmail.com", useraddress0);
        Employee employee0 = new Employee("Juan Pinturas", userdata0, useraddress0);

        registereds.Register(employee0);
        employee0.CreateOffer(1, "Pintar la casa", 1000, "Pintura", employee0);
        employee0.CreateOffer(2, "Pintar el auto", 500, "Pintura", employee0);
    }
    public void Test6_7_8()
    {
        var categorys = new CategoryCatalog();
        var registereds = new Registereds();
        var admin = new Administrador("eladmin");

        Address useraddress0 = new Address("Calle falsa 123", "Buenos Aires Ciudad", "Buenos Aires", "Argentina", "C1425BQO");
        PersonalData userdata0 = new PersonalData("Juan", "Perez", "095101010", "JuanchoPerez@gmail.com", useraddress0);
        Employer employer0 = new Employer("Juan Pinturas", userdata0, useraddress0);


        Address useraddress1 = new Address("Calle falsa 123", "Buenos Aires", "Buenos Aires", "Argentina", "C1425BQO");
        PersonalData userdata1 = new PersonalData("Juan", "Perez", "095101010", "JuanchoPerez@gmail.com", useraddress0);
        Employee employee0 = new Employee("Juan Pinturas", userdata1, useraddress1);

        registereds.Register(employee0);
        employee0.CreateOffer(1, "Pintar la casa", 1000, "Pintura", employee0);
        employee0.CreateOffer(2, "Lavar el auto", 500, "Limpieza", employee0);

        admin.GetOffers();
        admin.GetOffersByCategory("Pintura");
        admin.GetOffersByUbication("Buenos Aires Ciudad");

    }
}