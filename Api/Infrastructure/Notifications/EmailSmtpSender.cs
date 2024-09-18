using Api.Applicartion;
using Api.Applicartion.EmailSender;
using Api.Domain.Entities;
using MediatR;

namespace Api.Infrastructure.Notifications
{
    public class EmailSmtpSender : IRequestHandler<EmailNotificationRequest>
    {
        public async Task Handle(EmailNotificationRequest request, CancellationToken cancellationToken)
        {
            var template = "<p>Producto: {Name}</p>";
            template.Replace(template, request.Message);

            Console.WriteLine("Enviando email");
            await Task.CompletedTask;
        }

    }
}
