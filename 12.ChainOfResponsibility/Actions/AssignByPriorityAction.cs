using System;

namespace _12.ChainOfResponsibility.Actions
{
    public class AssignByPriorityAction : CancelAction
    {
        public AssignByPriorityAction(CancelAction cancelAction) : base(cancelAction)
        {
        }

        public override void Execute(Ticket ticket, DateTime cancelTime)
        {
            TimeLine timeLine = ticket.Plan.TimeLine;
            if (base.InActionTime(timeLine.PODeadLine, timeLine.ManagerDeadLine, cancelTime))
            {
                Console.WriteLine(nameof(AssignByPriorityAction) + ": " + nameof(Execute));
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
