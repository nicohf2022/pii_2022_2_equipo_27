namespace Library
{
    /// <summary>
    /// Clase encargada de encapsular la información personal.
    /// De acuerdo a SRP, la responsabilidad de tener la información personal y los datos
    /// de la ubicación (Address) son dos razones de cambio y por lo tanto deben separarse.
    /// </summary>
    public class PersonalData
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        
        public PersonalData(string name, string lastname)
        {
            this.Name = name;
            this.LastName = lastname;
        }
    }
}