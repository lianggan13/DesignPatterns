using System;

namespace _12.ChainOfResponsibility.Actions
{
    public class DefaultAction : CancelAction
    {
        public override void Execute(Ticket ticket, DateTime cancelTime)
        {
            ticket.CurrentState = "CANCELED";
            Console.WriteLine(nameof(Ticket.CurrentState) + ": " + ticket.CurrentState);
        }
    }
}
