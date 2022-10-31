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

}