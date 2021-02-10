using System;

namespace _12.ChainOfResponsibility.Actions
{
    public class SendEmailAction : CancelAction
    {
        public SendEmailAction(CancelAction cancelAction) : base(cancelAction)
        {
        }

        public override void Execute(Ticket ticket, DateTime cancelTime)
        {
            TimeLine timeLine = ticket.Plan.TimeLine;
            if (base.InActionTime(timeLine.TicketAssignedTime, timeLine.PODeadLine, cancelTime))
            {
                Console.WriteLine(nameof(SendEmailAction) + ": " + nameof(Execute));
            }
            else
            {
                if (hasNextAction)
                {
                    nextAction.Execute(ticket, cancelTime);
                }
            }
        }
    }
}
