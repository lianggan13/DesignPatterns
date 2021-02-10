using _12.ChainOfResponsibility.Actions;
using System;

namespace _12.ChainOfResponsibility
{
    public class TrainingPlan
    {
        public TimeLine TimeLine { get; private set; }
        public TrainingPlan()
        {
            DateTime dt = DateTime.Now;
            TimeLine = new TimeLine(dt, dt.AddDays(2), dt.AddDays(4), dt.AddDays(6), dt.AddDays(8));
        }
    }
}
