namespace Library
{

    /*Utilizamos la clase Worker como clase base para la clase Employer*/

    public class Employer : WorkUser
    {
/*Agregamos el constructor de la clase Employer utlizando composicion de la clase PersonalData */
        public Employer(string nickname, PersonalData personalData)
        : base(nickname, personalData)
        {
            Registereds.Register(this);
        }
        

        /// <summary>
        /// Devuelve string con la información de contacto o con mensaje de error si no lo encuentra.
        /// </summary>
        /// <param name="Nickname"></param>
        /// <returns></returns>
       
       
       /*Utilizamos el principio srp*/
        public string ContactEmployee(string Nickname)
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