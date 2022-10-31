namespace Library;
public class Employee : WorkUser
{
    public Employee(string nickname, PersonalData personalData, Address address)
    : base(nickname, personalData, address)
    {
        
    }
    public void CreateOffer(int offerid, string description, int price, string category, Employee employee)
    {
        Offer offer = new Offer(offerid, description, price, category, this);
    }

    /// <summary>
    /// Devuelve string con la información de contacto o con mensaje de error si no lo encuentra.
    /// </summary>
    /// <param name="Nickname"></param>
    /// <returns></returns>
    private string ContactEmployer(string Nickname)
    {
        Employer element;

        for (int i = 0; i < Registereds.Employers.GetLength(); i++)
        {
            element = Registereds.Employers.GetByIndex(i);
            if (element.NickName == Nickname)
            {
                return element.ContactInfo.GetContactInfo();
            }
        }
        return "No hay ningun Empleador registrado con el Nickname ingresado";
    }
}
