namespace Library
{
    /// <summary>
    /// Asignamos la responsabilidad de devolver el numero y el email de acuerdo
    /// al patron Expert, dado que ContactInfo es quien sabe toda la información.
    /// </summary>
    public class ContactInfo
    {
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public Address Address { get; private set; }
        
        public ContactInfo(string phone, string email, Address address)
        {
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
        }

        /// <summary>
        /// Devuelve un string conteniendo nro. celular y E-Mail.
        /// </summary>
        /// <returns></returns>
        
        /* Utilizando patron Expert*/
        public string GetContactInfo()
        {
            return $"Phone: {this.Phone} - Email: {this.Email}";
        }
    }
}