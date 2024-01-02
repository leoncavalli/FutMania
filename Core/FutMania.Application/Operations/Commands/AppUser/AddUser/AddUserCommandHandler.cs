using FutMania.Application.Operations.Commands.AddUser;
using FutMania.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace FutMania.Application;

public class AddUserCommandHandler : IRequestHandler<AddUserCommandRequest, AddUserCommandResponse>
{
    readonly UserManager<AppUser> _userManager;
    public AddUserCommandHandler(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }
    public async Task<AddUserCommandResponse> Handle(AddUserCommandRequest request, CancellationToken cancellationToken)
    {  
        var result = await _userManager.CreateAsync(new(){UserName = request.Username,Email= request.Email},password:request.Password);
        AddUserCommandResponse response = new();
        if(result.Succeeded){
            response.Status=true;
            response.Message="User created successfully!";
        }
        else{
            response.Status=false;
            response.Message = "An error occured";
        }
        return response;
    }
}
