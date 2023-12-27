using MediatR;

namespace FutMania.Application.Operations.Commands.DeletePlayer;

public class DeletePlayerCommandRequest:IRequest<DeletePlayerCommandResponse>
{
    public string Id { get; set; }
}
