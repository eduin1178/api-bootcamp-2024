using Api.Applicartion.Users.Commands;
using Api.Applicartion.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }


        [HttpGet("{email}")]
        public async Task<IActionResult> Get(string email)
        {
            var request = new GetUserByEmailIdRequest
            {
                Email = email,
            };
            var user = await _mediator.Send(request);

            return Ok(user);
        }
    }
}
