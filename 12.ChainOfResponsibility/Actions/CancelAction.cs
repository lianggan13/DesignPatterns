using System;

namespace _12.ChainOfResponsibility.Actions
{
    public abstract class CancelAction
    {
        protected CancelAction nextAction;
        protected bool hasNextAction;

        public abstract void Execute(Ticket ticket, DateTime cancelTime);
        public CancelAction()
        {
        }
        public CancelAction(CancelAction cancelAction)
        {
            this.nextAction = cancelAction;
            this.hasNextAction = true;
        }



        protected bool InActionTime(DateTime startTime, DateTime endTime, DateTime currentTime)
        {
            //return false;
            return currentTime >= startTime && currentTime <= endTime;

        }
    }
}
