using WMRent.Business.Interfaces;
using WMRent.Business.Notifications;

namespace WMRent.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotifier _notifier;

        protected BaseService(INotifier notifier)
        {
            _notifier = notifier;
        }

        protected void Notifier(string mensagem)
        {
            _notifier.Handle(new Notification(mensagem));
        }
    }
}
