using MediatR;

namespace Api.Applicartion.EmailSender
{
    public sealed record EmailNotificationRequest(string Email, string Subject, string Message):IRequest;
}
