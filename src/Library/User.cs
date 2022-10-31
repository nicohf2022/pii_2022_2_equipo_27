namespace Library
{
    /// <summary>
    /// Esta clase fue ideada de acuerdo a los principios de OCP y DIP.
    /// La idea es abstraer lo que compone a cada usuario y asignarlo a esta clase,
    /// para luego ser la base de las clases de los Usuarios (Trabajador, Empleador y Admin.).
    /// </summary>
    public class User
    {   
        public string NickName { get; protected set; }
        public int Reputation { get; set; }

        public User(string nickname)
        {
            this.NickName = nickname;
        }
    }
}