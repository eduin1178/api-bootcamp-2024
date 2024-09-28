using Api.Applicartion;
using Api.Applicartion.EmailSender;
using Api.Applicartion.Notifications;

namespace Api.Infrastructure.Notifications
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(EmailNotificationRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task SendEmailAsync(UserCreatedNotification request)
        {
            Console.WriteLine($"Email sent to {request.Email}");
            await Task.CompletedTask;
        }
    }
}
