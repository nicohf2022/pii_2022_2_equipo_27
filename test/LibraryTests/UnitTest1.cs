using Library;

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
        string input = "algo";
        MessageReceiver.Receive(input);

        input = "algo2";
        MessageReceiver.Receive(input);

        input = "Category";
        MessageReceiver.Receive(input);

        List<string> expectedList = new List<string>();
        expectedList.Add(input3);

        Category categorias = new Category();
        var resultList = categorias.GetOffers();
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
        string input = "algo";
        MessageReceiver.Receive(input);

        input = "algo2";
        MessageReceiver.Receive(input);

        Category categoria = new Category();
        Offer oferta1 = new Offer(1, "descripcion", 100, categoria);
        Offer oferta2 = new Offer(2, "descripcion", 100, categoria);
        Offer oferta3 = new Offer(3, "descripcion", 100, categoria);

        List<Offer> expectedList = Offer.GetOffers();

        input = "2";
        MessageReceiver.Receive(input);

        expectedList.Remove(oferta2);

        List<Offer> resultList = Offer.GetOffers();

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
        string input = "algo";
        MessageReceiver.Receive(input);

        input = "algo2";
        MessageReceiver.Receive(input);

        input = "FrancoBascialla, Franco, Bascialla, 095349142, francobascialla@gmail.com";
        MessageReceiver.Receive(input);

        input = "Avenida avenida, Punta del Este, Maldonado, Uruguay, 20100";
        MessageReceiver.Receive(input);

        Address address = new Address("Avenida avenida", "Punta del Este", "Maldonado", "Uruguay", "20100");
        PersonalData personalData = new PersonalData("Franco", "Bascialla", "095349142", "francobascialla@gmail.com", address);
        Employee employee = new Employee("FrancoBascialla", personalData, address);
        string expectedNickName = employee.NickName;

        string resultNickName = Registereds.Employees.SearchByInt(0).NickName;

        Assert.That(resultNickName, Is.EqualTo(expectedNickName));
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
        string input = "algo";
        MessageReceiver.Receive(input);

        input = "algo2";
        MessageReceiver.Receive(input);

        input = "FrancoBascialla, Franco, Bascialla, 095349142, francobascialla@gmail.com";
        MessageReceiver.Receive(input);

        input = "Avenida avenida, Punta del Este, Maldonado, Uruguay, 20100";
        MessageReceiver.Receive(input);

        Address address = new Address("Avenida avenida", "Punta del Este", "Maldonado", "Uruguay", "20100");
        PersonalData personalData = new PersonalData("Franco", "Bascialla", "095349142", "francobascialla@gmail.com", address);
        Employer employer = new Employer("FrancoBascialla", personalData, address);
        string expectedNickName = employer.NickName;

        string resultNickName = Registereds.Employers.SearchByInt(0).NickName;

        Assert.That(resultNickName, Is.EqualTo(expectedNickName));
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