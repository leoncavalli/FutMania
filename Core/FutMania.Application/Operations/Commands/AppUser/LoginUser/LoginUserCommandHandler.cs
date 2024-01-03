﻿using FutMania.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace FutMania.Application.Operations.Commands.LoginUser;

public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
{
    readonly UserManager<AppUser> _userManager;
    readonly SignInManager<AppUser> _signInManager;
    public LoginUserCommandHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(request.UsernameOrEmail);
        if (user == null)
            user = await _userManager.FindByEmailAsync(request.UsernameOrEmail);
        if(user==null)
            return new(){Status=false};
        var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
        return new() { Status = result.Succeeded };
    }
}
