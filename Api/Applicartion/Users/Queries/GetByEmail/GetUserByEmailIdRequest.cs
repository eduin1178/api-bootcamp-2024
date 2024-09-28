using MediatR;

namespace Api.Applicartion.Users.Queries
{
    public record GetUserByEmailIdRequest : IRequest<UserResponse>
    {
        public string Email { get; init; }
    }
}
