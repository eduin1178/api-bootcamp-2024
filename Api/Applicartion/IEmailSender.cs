using Api.Applicartion.EmailSender;

namespace Api.Applicartion
{
    public interface IEmailSender
    {
        Task SendEmailAsync(EmailNotificationRequest request);
    }
}
