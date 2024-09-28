using MediatR;

namespace Api.Applicartion.Users.Commands
{
    public record CreateUserCommand : IRequest
    {
        public string Name { get; init; }
        public string Email { get; init; }
        public string PhoneNumber { get; init; }
    }
}
