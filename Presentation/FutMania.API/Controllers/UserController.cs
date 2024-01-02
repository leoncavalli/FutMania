using FutMania.Application.Operations.Commands.AddUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutMania.API.Controllers;

public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(AddUserCommandRequest addUserCommandRequest){
        var response = await _mediator.Send(addUserCommandRequest);
        return Ok(response);
    }
}
