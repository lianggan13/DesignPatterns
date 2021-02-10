namespace _12.ChainOfResponsibility.Actions
{
    public class CancelActionCreator
    {
        public virtual CancelAction Create()
        {
            CancelAction def = new DefaultAction();
            CancelAction noShow = new NoShowAction(def);
            CancelAction lost = new LostAction(noShow);
            CancelAction assign = new AssignByPriorityAction(lost);
            CancelAction sendEmail = new SendEmailAction(assign);

            return sendEmail;
        }
    }
}
