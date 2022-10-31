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

        string input = "algo";
        MessageReciver.Recive(input);

        input = "algo2";
        MessageReciver.Recive(input);

        input = "Calle falsa 123, Buenos Aires Ciudad, Buenos Aires, Argentina, C1425BQO";
        MessageReciver.Recive(input);

        input = "Juan, Perez, 095101010, JuanchoPerez@gmail.com";
        MessageReciver.Recive(input);

        Address useraddress0 = new Address("Calle falsa 123", "Buenos Aires Ciudad", "Buenos Aires", "Argentina", "C1425BQO");
        PersonalData userdata0 = new PersonalData("Juan", "Perez", "095101010", "JuanchoPerez@gmail.com", useraddress0);
        Employee employee0 = new Employee("Juan Pinturas", userdata0, useraddress0);

        registereds.Register(employee0);
        employee0.CreateOffer(1, "Pintar la casa", 1000, "Pintura", employee0);
        var result = Offer.Offers[0].Description;
        var expected = "Pintar la casa";
        Assert.That(result, Is.EqualTo(expected));
    }
    public void Test6()
    {
        var categorys = new CategoryCatalog();
        var registereds = new Registereds();
        var admin = new Administrador("eladmin");

        string input = "algo";
        MessageReciver.Recive(input);

        input = "algo2";
        MessageReciver.Recive(input);

        input = "Calle falsa 321, Montevideo, Pozos, Uruguay, C1425BQO";
        MessageReciver.Recive(input);

        input = "Pedro, Soan, 095123123, Pedrinho777@gmail.com";
        MessageReciver.Recive(input);

        Address useraddress0 = new Address("Calle falsa 123", "Montevideo", "Pozos", "Uruguay", "C1425BQO");
        PersonalData userdata0 = new PersonalData("Pedro", "Soan", "095123123", "Pedrinho777@gmail.com", useraddress0);
        Employer employer0 = new Employer("Pedro", userdata0, useraddress0);


        Address useraddress1 = new Address("Calle falsa 123", "Buenos Aires", "Buenos Aires", "Argentina", "C1425BQO");
        PersonalData userdata1 = new PersonalData("Juan", "Perez", "095101010", "JuanchoPerez@gmail.com", useraddress0);
        Employee employee0 = new Employee("Juan Pinturas", userdata1, useraddress1);

        registereds.Register(employee0);
        employee0.CreateOffer(1, "Pintar la casa", 1000, "Pintura", employee0);

        var result = admin.GetOffers(); // "Pintar la casa"
        var expected = "Pintar la casa";
        Assert.That(result, Is.EqualTo(expected));
    }
    public void Test7()
    {
        var categorys = new CategoryCatalog();
        var registereds = new Registereds();
        var admin = new Administrador("eladmin");

        string input = "algo";
        MessageReciver.Recive(input);

        input = "algo2";
        MessageReciver.Recive(input);

        input = "Calle falsa 321, Montevideo, Pozos, Uruguay, C1425BQO";
        MessageReciver.Recive(input);

        input = "Pedro, Soan, 095123123, Pedrinho777@gmail.com";
        MessageReciver.Recive(input);

        Address useraddress0 = new Address("Calle falsa 123", "Montevideo", "Pozos", "Uruguay", "C1425BQO");
        PersonalData userdata0 = new PersonalData("Pedro", "Soan", "095123123", "Pedrinho777@gmail.com", useraddress0);
        Employee employee0 = new Employee("Pedro", userdata0, useraddress0);


        Address useraddress1 = new Address("Calle falsa 123", "Buenos Aires", "Buenos Aires", "Argentina", "C1425BQO");
        PersonalData userdata1 = new PersonalData("Juan", "Perez", "095101010", "JuanchoPerez@gmail.com", useraddress0);
        Employee employee1 = new Employee("Juan Pinturas", userdata1, useraddress1);

        registereds.Register(employee0);
        employee0.CreateOffer(1, "Pintar la cucha", 1000, "Pintura", employee0);
        employee1.CreateOffer(2, "Pintar la casa", 1000, "Pintura", employee1);

        var result = admin.GetOffersByUbication("Montevideo"); 
        var expected = "Pintar la cucha";
        Assert.That(result, Is.EqualTo(expected));
    }
    public void Test8()
    {
        var categorys = new CategoryCatalog();
        var registereds = new Registereds();
        var admin = new Administrador("eladmin");

        string input = "algo";
        MessageReciver.Recive(input);

        input = "algo2";
        MessageReciver.Recive(input);

        input = "Calle falsa 321, Montevideo, Pozos, Uruguay, C1425BQO";
        MessageReciver.Recive(input);

        input = "Pedro, Soan, 095123123, Pedrinho777@gmail.com";
        MessageReciver.Recive(input);

        Address useraddress0 = new Address("Calle falsa 123", "Montevideo", "Pozos", "Uruguay", "C1425BQO");
        PersonalData userdata0 = new PersonalData("Pedro", "Soan", "095123123", "Pedrinho777@gmail.com", useraddress0);
        Employee employee0 = new Employee("Pedro", userdata0, useraddress0);


        Address useraddress1 = new Address("Calle falsa 123", "Buenos Aires", "Buenos Aires", "Argentina", "C1425BQO");
        PersonalData userdata1 = new PersonalData("Juan", "Perez", "095101010", "JuanchoPerez@gmail.com", useraddress0);
        Employee employee1 = new Employee("Juan Pinturas", userdata1, useraddress1);

        registereds.Register(employee0);
        employee0.CreateOffer(1, "Pintar la cucha", 1000, "Pintura", employee0);
        employee1.Reputation = 5;
        employee1.CreateOffer(2, "Pintar la casa", 1000, "Pintura", employee1);

        var result = admin.GetOffersByReputation(); 
        var expected = "Pintar la casa";
        Assert.That(result, Is.EqualTo(expected));
    }
    public void Test9()
    {
    }
}