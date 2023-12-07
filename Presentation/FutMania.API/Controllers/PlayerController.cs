using FutMania.Application;
using FutMania.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FutMania.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }
        [HttpPost]
        public async Task<IActionResult> AddPlayer(Player player)
        {
            await _playerService.AddPlayer(player);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetPlayers()
        {
            var players = _playerService.GetPlayers();
            return Ok(players);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetPlayer(string id)
        {
            var player = await _playerService.GetPlayer(id);
            return Ok(player);
        }
    }
}