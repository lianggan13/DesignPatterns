using System;

namespace _12.ChainOfResponsibility.Actions
{
    public class NoShowAction : CancelAction
    {
        public NoShowAction(CancelAction cancelAction) : base(cancelAction)
        {
        }

        public override void Execute(Ticket ticket, DateTime cancelTime)
        {
            TimeLine timeLine = ticket.Plan.TimeLine;
            if (base.InActionTime(timeLine.NoShowDeadLine, timeLine.TrainingEndTime, cancelTime))
            {
                Console.WriteLine(nameof(NoShowAction) + ": " + nameof(Execute));
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
