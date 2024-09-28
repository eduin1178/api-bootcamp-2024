using Api.Domain.Entities;
using Api.Domain.Repositories;
using Api.Domain.UnitOfWork;
using MediatR;

namespace Api.Applicartion.Users.Queries
{
    public class GerUserByEmailRequestHandler : IRequestHandler<GetUserByEmailIdRequest, UserResponse>
    {
        private readonly IUserRepository _userRepository;

        public GerUserByEmailRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserResponse> Handle(GetUserByEmailIdRequest request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByEmail(request.Email);

            return new UserResponse()
            {
                Id = user.Id,
                Name = user.Username,
                Email = user.Email,
                PhoneNumber = user.Password
            };
        }
    }
}
