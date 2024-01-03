using FutMania.Application.DTOs;

namespace FutMania.Application.Operations.Commands.LoginUser;

public class LoginUserCommandResponse
{
    public Token Token { get; set; }
    public bool Status { get; set; }
}
