namespace Library
{
    public class User
    {   
        public string NickName { get; protected set; }
//        public Rubro Rubro { get; set; }
        public int Reputation { get; protected set; }

        public User(string nickname)
        {
            this.NickName = nickname;
        }
    }
}