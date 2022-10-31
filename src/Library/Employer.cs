namespace Library
{
    public class Employer : WorkUser
    {
        public Employer(string nickname, PersonalData personalData, Address address)
        : base(nickname, personalData, address)
        {

        }
        

        /// <summary>
        /// Devuelve string con la información de contacto o con mensaje de error si no lo encuentra.
        /// </summary>
        /// <param name="Nickname"></param>
        /// <returns></returns>
        private string ContactEmployee(string Nickname)
        {
            Employee element;

            for (int i = 0; i < Registereds.Employees.GetLength(); i++)
            {
                element = Registereds.Employees.GetByIndex(i);
                if (element.NickName == Nickname)
                {
                    return element.ContactInfo.GetContactInfo();
                }
            }
            return "No hay ningun Empleado registrado con el Nickname ingresado";
        }
    }
}