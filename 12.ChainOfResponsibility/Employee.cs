namespace _12.ChainOfResponsibility
{
    public class Employee
    {
        public Ticket Ticket { get; private set; }

        public void PullTicket(Ticket ticket)
        {
            this.Ticket = ticket;
        }

        public void CancelTicket()
        {
            Ticket.Cancel();
        }

    }
}
