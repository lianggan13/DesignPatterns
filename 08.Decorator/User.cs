namespace _08.Decorator
{
    public abstract class User
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public User()
        {

        }
        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        public abstract void SignIn();
    }
}
