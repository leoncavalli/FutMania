using FutMania.Domain.Entities;

namespace FutMania.Application.Interfaces{
public interface ITeamService
{
    List<Team> GetTeams();
}
}