using Api.Applicartion.EmailSender;
using Api.Applicartion.Notifications;

namespace Api.Applicartion
{
    public interface IEmailSender
    {
        Task SendEmailAsync(EmailNotificationRequest request);
        Task SendEmailAsync(UserCreatedNotification request);
    }
}
