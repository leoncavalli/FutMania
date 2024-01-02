using MediatR;

namespace FutMania.Application.Operations.Commands.AddUser;

public class AddUserCommandRequest : IRequest<AddUserCommandResponse>
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    

}
