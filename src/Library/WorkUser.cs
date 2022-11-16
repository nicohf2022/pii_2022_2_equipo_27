namespace Library
{
    /// <summary>
    /// Al igual que la clase User, esta clase también se basa en los principios de OCP y DIP.
    /// Abstraemos lo que compone a los trabajadores y empleadores, quedando abierto a agregar
    /// fácilmente nuevas clases de menor nivel.
    /// </summary>
    
    /*Agregamos la clase WorkUser que hereda de User PersonalData.
    Todos los WorkUser contienen atributos de PersonalData.*/
    public class WorkUser : User
    {
        public PersonalData PersonalData { get; private set; }
        public int Reputation { get; set; }=3;
        public int TimesQualified { get; set; }=1;

    /*Agregamos el constructor de la clase WorkUser utlizando composicion de la clase PersonalData.
    Tanto Employee como Employer tienen PersonalData, pero los Employer no tienen ContactInfo*/
        public WorkUser(string nickname, PersonalData personalData)
        : base(nickname)
        {
            this.PersonalData = personalData;
        }
    
    /*Agregado por Expert*/
    public void Qualified(int reputation)
    {
        this.Reputation += reputation;
        this.TimesQualified+=1;

        this.Reputation = this.Reputation / this.TimesQualified;
    }
    

    }
}