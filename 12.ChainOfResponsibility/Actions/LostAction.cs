using System;

namespace _12.ChainOfResponsibility.Actions
{
    public class LostAction : CancelAction
    {
        public LostAction(CancelAction cancelAction) : base(cancelAction)
        {
        }

        public override void Execute(Ticket ticket, DateTime cancelTime)
        {
            TimeLine timeLine = ticket.Plan.TimeLine;
            if (base.InActionTime(timeLine.ManagerDeadLine, timeLine.NoShowDeadLine, cancelTime))
            {
                Console.WriteLine(nameof(LostAction) + ": " + nameof(Execute));
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
