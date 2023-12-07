using FutMania.Application.Repositories;
using FutMania.Domain.Entities;
namespace FutMania.Application;

public class PlayerService : IPlayerService
{
    private readonly IPlayerReadRepository _readRepository;
    private readonly IPlayerWriteRepository _writeRepository;

    public PlayerService(IPlayerReadRepository readRepository,IPlayerWriteRepository writeRepository)
    {
        _writeRepository = writeRepository;
        _readRepository = readRepository;
    }

    public async Task AddPlayer(Player player)
    {
        await _writeRepository.AddAsync(player);
        await _writeRepository.SaveAsync();
    }

    public async Task<Player> GetPlayer(string id)
    {
        var player = await _readRepository.GetByIdAsync(id); 
        return player;
    }

    public IEnumerable<Player> GetPlayers()
    {
        var players =  _readRepository.GetAll(); 
        return players;
    }
}

