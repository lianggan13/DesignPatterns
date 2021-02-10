using System;

namespace _08.Decorator
{
    public class LogDecorator : User
    {
        private User user;
        public LogDecorator(User user)
        {
            this.user = user;
        }

        public override void SignIn()
        {
            this.user.SignIn();
            Logging();
        }



        private void Logging()
        {
            Console.WriteLine(this.user.Name + " " + nameof(Logging));
        }
    }
}
