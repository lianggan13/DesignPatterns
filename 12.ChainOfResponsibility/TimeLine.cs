using System;

namespace _12.ChainOfResponsibility.Actions
{
    public class TimeLine
    {
        public DateTime TicketAssignedTime { get; private set; }
        public DateTime PODeadLine { get; private set; }
        public DateTime ManagerDeadLine { get; private set; }
        public DateTime NoShowDeadLine { get; private set; }
        public DateTime TrainingEndTime { get; private set; }


        public TimeLine(DateTime ticketAssignedTime, DateTime pODeadLine, DateTime managerDeadLine, DateTime noShowDeadLine, DateTime trainingEndTime)
        {
            TicketAssignedTime = ticketAssignedTime;
            PODeadLine = pODeadLine;
            ManagerDeadLine = managerDeadLine;
            NoShowDeadLine = noShowDeadLine;
            TrainingEndTime = trainingEndTime;
        }
    }
}