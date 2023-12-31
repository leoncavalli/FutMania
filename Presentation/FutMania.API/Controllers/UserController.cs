﻿using FutMania.Application.Operations.Commands.AddUser;
using FutMania.Application.Operations.Commands.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutMania.API.Controllers;

[Route("api/[controller]")]
[ApiController]
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
    [HttpPost("[action]")]
    public async Task<IActionResult> Login(LoginUserCommandRequest loginUserCommandRequest)
    {
        LoginUserCommandResponse response = await _mediator.Send(loginUserCommandRequest); 
        return Ok(response);
    }
}
