namespace Library
{
    /// <summary>
    /// Al igual que la clase User, esta clase también se basa en los principios de OCP y DIP.
    /// Abstraemos lo que compone a los trabajadores y empleadores, quedando abierto a agregar
    /// fácilmente nuevas clases de menor nivel.
    /// </summary>
    public class WorkUser : User
    {
        public PersonalData PersonalData { get; private set; }
        public int Reputation { get; set; }

        public WorkUser(string nickname, PersonalData personalData)
        : base(nickname)
        {
            this.PersonalData = personalData;
        }
    }
}