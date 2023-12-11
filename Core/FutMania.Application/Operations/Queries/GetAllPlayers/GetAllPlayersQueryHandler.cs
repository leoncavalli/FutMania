using FutMania.Application.Repositories;
using MediatR;

namespace FutMania.Application;

public class GetAllPlayersQueryHandler : IRequestHandler<GetAllPlayersQueryRequest, GetAllPlayersQueryResponse>
{
    readonly IPlayerReadRepository _playerReadRepository;
    public GetAllPlayersQueryHandler(IPlayerReadRepository playerReadRepository)
    {
        _playerReadRepository = playerReadRepository;
    }
    public async Task<GetAllPlayersQueryResponse> Handle(GetAllPlayersQueryRequest request, CancellationToken cancellationToken)
    {
        var players = _playerReadRepository.GetAll(false);
        var playersObj =  _playerReadRepository.GetAll().Select(x=>new{}).ToList();
        var totalCount =  players.Count();
        return new()
        {
            TotalCount = totalCount,
            Players = players
        };
    }
}
