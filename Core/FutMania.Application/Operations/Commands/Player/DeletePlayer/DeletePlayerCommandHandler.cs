using FutMania.Application.Repositories;
using MediatR;

namespace FutMania.Application.Operations.Commands.DeletePlayer;

public class DeletePlayerCommandHandler : IRequestHandler<DeletePlayerCommandRequest,DeletePlayerCommandResponse>
{
    readonly IPlayerWriteRepository _playerWriteRepository;
    public DeletePlayerCommandHandler(IPlayerWriteRepository playerWriteRepository)
    {
        _playerWriteRepository = playerWriteRepository;
    }
    public async Task<DeletePlayerCommandResponse> Handle(DeletePlayerCommandRequest request, CancellationToken cancellationToken)
    {
        await _playerWriteRepository.RemoveAsync(request.Id);
        await _playerWriteRepository.SaveAsync();
        return new();
    }
}
