namespace _12.ChainOfResponsibility
{
    public class Manager
    {
        public Ticket PushTicket()
        {
            return new Ticket();
        }

    }
}
