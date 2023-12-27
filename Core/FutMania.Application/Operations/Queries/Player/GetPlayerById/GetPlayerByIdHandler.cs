using FutMania.Application.Repositories;
using MediatR;

namespace FutMania.Application.Operations.Queries.GetPlayerById;

public class GetPlayerByIdHandler : IRequestHandler<GetPlayerByIdRequest,GetPlayerByIdResponse>
{
    readonly IPlayerReadRepository _playerReadRepository;
    public GetPlayerByIdHandler(IPlayerReadRepository playerReadRepository)
    {
        _playerReadRepository = playerReadRepository;
    }

    public async Task<GetPlayerByIdResponse> Handle(GetPlayerByIdRequest request,CancellationToken cancellationToken){
        var player = await _playerReadRepository.GetByIdAsync(request.Id);
        return new(){
            Id=player.Id.ToString(),
            Name=player.Name,
            LastName=player.LastName,
        };
    }
}
