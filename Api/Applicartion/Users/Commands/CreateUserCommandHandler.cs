using Api.Applicartion.Notifications;
using Api.Domain.Entities;
using Api.Domain.Repositories;
using Api.Domain.UnitOfWork;
using MediatR;

namespace Api.Applicartion.Users.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPublisher _publisher;
        public CreateUserCommandHandler(
            IUserRepository userRepository,
            IUnitOfWork unitOfWork, 
            IPublisher publisher)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _publisher = publisher;
        }
        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = new User()
            {
                Username = request.Name,
                Email = request.Email,
                Password = request.PhoneNumber
            };

            _userRepository.Add(entity);

            await _unitOfWork.SaveChangesAsync(cancellationToken);
            var notification = new UserCreatedNotification
            {
                Id = entity.Id,
                Email = entity.Email,
                Name = entity.Username,
                PhoneNumber = entity.Password,
            };
            await _publisher.Publish(notification, cancellationToken);
        }
    }
}
