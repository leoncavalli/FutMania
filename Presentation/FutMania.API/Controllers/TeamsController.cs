using FutMania.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FutMania.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public IActionResult GetTeams()
        {
            var teams = _teamService.GetTeams();
            return Ok(teams );
        }
    }
}