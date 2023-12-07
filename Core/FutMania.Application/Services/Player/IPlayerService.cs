using FutMania.Domain.Entities;

namespace FutMania.Application;

public interface IPlayerService
{
    IEnumerable<Player> GetPlayers();
    Task<Player> GetPlayer(string id);
    Task AddPlayer(Player player);
}
