using FutMania.Application.Repositories;
using FutMania.Domain.Entities;
using FutMania.Persistance.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FutMania.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerReadRepository _playerReadRepository;
        private readonly IPlayerWriteRepository _playerWriteRepository;


        public PlayerController(IPlayerReadRepository playerReadRepository,IPlayerWriteRepository playerWriteRepository)
        {
            _playerReadRepository = playerReadRepository;
            _playerWriteRepository = playerWriteRepository;
        }
        [HttpPost]
        public async Task<IActionResult> AddPlayer()
        {
            await _playerWriteRepository.AddRangeAsync(new(){
                new(){Id=Guid.NewGuid(),Name="Edin",LastName="Dzeko",Info="",CreatedAt=DateTime.UtcNow}
            });
            await _playerWriteRepository.SaveAsync();
            return Ok();
        }
        [HttpGet]
        public IActionResult GetPlayers()
        {
            var players = _playerReadRepository.GetAll(); 
            return Ok(players);
        }

        [HttpGet("{id}")]

        public IActionResult GetPlayer(string id)
        {
            var player = _playerReadRepository.GetByIdAsync(id); 
            return Ok(player);
        }
    }
}