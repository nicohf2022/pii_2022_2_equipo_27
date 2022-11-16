namespace Library

/*Es la clase que contiene la direccion de un usuario*/

{

    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string PostalCode { get; private set; }



/*Constructor de la clase Address.Recibe como parametros los datos del usuario.*/
        public Address(string street, string city, string state, string country, string postalcode)
        {
            this.Street = street;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.PostalCode = postalcode;
        }
    }
}