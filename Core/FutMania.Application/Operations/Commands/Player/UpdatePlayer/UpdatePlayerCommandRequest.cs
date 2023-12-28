using MediatR;

namespace FutMania.Application.Operations.Commands.UpdatePlayer;

public class UpdatePlayerCommandRequest : IRequest<UpdatePlayerCommandResponse>
{
    public string Id { get; set; }
    public string Info { get; set; }

}
