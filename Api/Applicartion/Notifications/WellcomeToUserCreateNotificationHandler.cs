using MediatR;

namespace Api.Applicartion.Notifications;

public class WellcomeToUserCreateNotificationHandler : INotificationHandler<UserCreatedNotification>
{
    private readonly IEmailSender _emailSender;

    public WellcomeToUserCreateNotificationHandler(IEmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public async Task Handle(UserCreatedNotification notification, CancellationToken cancellationToken)
    {
        await _emailSender.SendEmailAsync(notification);
    }
}
