namespace WMRent.Business.Notifications
{
    public class Notification
    {
        public string message { get; set; }

        public Notification(string mensagem)
        {
            message = mensagem;
        }
    }
}
