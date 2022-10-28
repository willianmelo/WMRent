using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using WMRent.Business.Interfaces;
using WMRent.Business.Notifications;

namespace WMRent.API.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotifier _notifier;

        protected Guid UsuarioId { get; set; }
        protected bool UsuarioAutenticado { get; set; }

        protected MainController(INotifier notificador)
        {
            _notifier = notificador;
        }

        protected bool IsValidOperation()
        {
            return !_notifier.HasNotification();
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (IsValidOperation())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = _notifier.GetNotifications().Select(n => n.message)
            });
        }

        protected ActionResult CustomResponse(ValidationResult modelState)
        {
            if (!modelState.IsValid)
            {
                NotifyInvalidObject(modelState);
            }

            return CustomResponse();
        }

        protected void NotifyInvalidObject(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
            {
                var errorMsg = $"{erro.ErrorCode} {erro.ErrorMessage}";
                NotifyError(errorMsg);
            }
        }

        protected void NotifyError(string message)
        {
            _notifier.Handle(new Notification(message));
        }
    }
}
