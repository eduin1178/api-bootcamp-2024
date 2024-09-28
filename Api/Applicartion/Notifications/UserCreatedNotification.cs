using MediatR;

namespace Api.Applicartion.Notifications
{
    public record UserCreatedNotification : INotification
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
    }
}
