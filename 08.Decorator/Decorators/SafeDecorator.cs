using System;

namespace _08.Decorator
{
    public class SafeDecorator : User
    {
        private User user;
        public SafeDecorator(User user)
        {
            this.user = user;
        }

        public override void SignIn()
        {
            if (IsValid())
            {
                this.user.SignIn();
            }
            else
            {
                Console.WriteLine(nameof(SignIn) + " is not " + nameof(IsValid));
            }
        }

        private bool IsValid()
        {
            return this.Name == "Admin" && this.Password == "1918";
        }
    }
}
