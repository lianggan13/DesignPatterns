using _12.ChainOfResponsibility.Actions;
using System;

namespace _12.ChainOfResponsibility
{
    public class Ticket
    {
        public TrainingPlan Plan { get; private set; }
        public string CurrentState { get; set; }
        public DateTime CancelTime { get; set; }

        public Ticket()
        {
            Plan = new TrainingPlan();
        }

        public void Cancel()
        {
            CancelAction action = new CancelActionCreator().Create();
            action.Execute(this, DateTime.Now);
        }
    }
}