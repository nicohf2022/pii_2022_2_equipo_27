using Library;
using NUnit.Framework;

namespace LibraryTests;

public class Tests
{
    /// <summary>
    /// Historias de usuario de administradores, trabajadores y empleadores:
    /// </summary>
    [Test]
    /// <summary>
    /// Cómo administrador, quiero poder indicar categorías sobre
    /// las cuales se realizarán las ofertas de servicios para que de
    /// esa forma,los trabajadoras puedan clasificarlos.
    /// </summary>
    public void TestAddCategory()
    {
        Administrador administrador = new Administrador("Admin1");
        string input = "Category";
        
        administrador.AddCategory(input);
        var resultList = CategoryCatalog.categories;

        List<Category> expectedList = new List<Category>();
        Category category = new Category(input);
        expectedList.Add(category);

        Assert.That(resultList, Is.EqualTo(expectedList));
    }
    
    [Test]
    /// <summary>
    /// Administrador:
    /// Como administrador, quiero poder dar de baja ofertas de servicios,
    /// avisando al oferente para que de esa forma, pueda evitar ofertas inadecudas.
    /// </summary>
    public void TestRemoveOffer()
    {
        Administrador administrador2 = new Administrador("Admin2");
        administrador2.AddCategory("categoria");

        Address address = new Address("calle", "ciudad", "estado", "pais", "codigopostal");
        ContactInfo contactInfo = new ContactInfo("091234567", "email", address);
        PersonalData personalData = new PersonalData("Nombre", "Apellido");
        Employee employee = new Employee("employee1", personalData, contactInfo);

        Offer oferta1 = new Offer(1, "descripcion", 100, "categoria", employee);
        Offer oferta2 = new Offer(2, "descripcion", 100, "categoria", employee);
        Offer oferta3 = new Offer(3, "descripcion", 100, "categoria", employee);

        administrador2.CancelOffer("descripcion", 1);

        List<Offer> expectedList = new List<Offer>();;
        expectedList.Add(oferta2);
        expectedList.Add(oferta3);

        List<Offer> resultList = Offer.Offers;

        Assert.That(resultList, Is.EqualTo(expectedList));
    }

    [Test]
    /// <summary>
    /// Trabajador:
    /// Como trabajador, quiero registrarme en la plataforma, indicando mis
    /// datos personales e información de contacto para que de esa forma, pueda
    /// proveer información de contacto a quienes quieran contratar mis servicios.
    /// </summary>
    public void TestEmployeeRegister()
    {
        Address address = new Address("Avenida avenida", "Punta del Este", "Maldonado", "Uruguay", "20100");
        ContactInfo contactInfo = new ContactInfo("091234567", "francobascialla@gmail.com", address);
        PersonalData personalData = new PersonalData("Franco", "Bascialla");
        Employee employee = new Employee("FrancoBascialla", personalData, contactInfo);

        string expectedNickName = "FrancoBascialla";
        PersonalData expectedPersonalData = personalData;
        ContactInfo expectedInfo = contactInfo;

        string resultNickName = employee.NickName;
        PersonalData resultPersonalData = employee.PersonalData;
        ContactInfo resultInfo = employee.ContactInfo;

        Assert.That(resultNickName, Is.EqualTo(expectedNickName));
        Assert.That(resultPersonalData, Is.EqualTo(expectedPersonalData));
        Assert.That(resultInfo, Is.EqualTo(expectedInfo));
    }

    [Test]
    /// <summary>
    /// Empleador:
    /// Como empleador, quiero registrarme en la plataforma, indicando mis datos
    /// personales e información de contacto para que de esa forma, pueda proveer
    /// información de contacto a los trabajadores que quiero contratar.
    /// </summary>
    public void TestEmployerRegister()
    {
        PersonalData personalData = new PersonalData("Franco", "Bascialla");
        Employer employer = new Employer("FrancoBascialla", personalData);

        string expectedNickName = "FrancoBascialla";
        PersonalData expectedPersonalData = personalData;

        string resultNickName = employer.NickName;
        PersonalData resultPersonalData = employer.PersonalData;

        Assert.That(resultNickName, Is.EqualTo(expectedNickName));
        Assert.That(resultPersonalData, Is.EqualTo(expectedPersonalData));
    }
    
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
    
    [Test]
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
    
    [Test]
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
    
    [Test]
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
    
    [Test]
    public void Test9()
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

        string input1 = "algo1";
        MessageReciver.Recive(input1);

        input = "algo2";
        MessageReciver.Recive(input1);

        input = "Calle falsa 555, Maldonado, PdE, Uruguay, 20000";
        MessageReciver.Recive(input);

        input = "Nestor, Lizboa, 091911505, Messi101@gmail.com";
        MessageReciver.Recive(input);

        Address useraddress1 = new Address("Calle falsa 123", "Montevideo", "Pozos", "Uruguay", "C1425BQO");
        PersonalData userdata1 = new PersonalData("Pedro", "Soan", "095123123", "Pedrinho777@gmail.com", useraddress0);
        Employee employer0 = new Employee("Pedro", userdata1, useraddress1);

        registereds.Register(employee0);
        registereds.Register(employer0);

        employer0.ContactEmployee(employee0, "Hola, me gustaria contratar sus servicios";
    }

}