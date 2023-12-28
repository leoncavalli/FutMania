using FutMania.Application.Repositories;
using MediatR;

namespace FutMania.Application.Operations.Commands.UpdatePlayer;

public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommandRequest, UpdatePlayerCommandResponse>
{
    readonly IPlayerWriteRepository _playerWriteRepository;
    readonly IPlayerReadRepository _playerReadRepository;
    public UpdatePlayerCommandHandler(IPlayerWriteRepository playerWriteRepository,IPlayerReadRepository playerReadRepository)
    {
        _playerWriteRepository = playerWriteRepository;
        _playerReadRepository = playerReadRepository;
    }
    public async Task<UpdatePlayerCommandResponse> Handle(UpdatePlayerCommandRequest request, CancellationToken cancellationToken)
    {
        var player =await _playerReadRepository.GetByIdAsync(request.Id);
        player.Info = request.Info;
        await _playerWriteRepository.SaveAsync();
        return new();
    }
}
