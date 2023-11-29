using FutMania.Application.Interfaces;
using FutMania.Domain.Entities;

namespace FutMania.Persistance.Services
{
    public class TeamService:ITeamService
    {
        public List<Team> GetTeams()
        {
            List<Team> dummyTeams = new(){
                new(){
                    Id = Guid.NewGuid(),
                    Name = "Fenerbahçe",
                    Country = "Türkiye",
                    Info = "1907'de kurulmuştur.",
                    CreatedAt = DateTime.UtcNow
                },
                new(){
                    Id = Guid.NewGuid(),
                    Name = "Beşiktaş",
                    Country = "Türkiye",
                    Info = "1903'de kurulmuştur.",
                    CreatedAt = DateTime.UtcNow
                },
                new(){
                    Id = Guid.NewGuid(),
                    Name = "Galatasaray",
                    Country = "Türkiye",
                    Info = "1905'de kurulmuştur.",
                    CreatedAt = DateTime.UtcNow
                }
            } ;
            return dummyTeams;
        }
    }

}