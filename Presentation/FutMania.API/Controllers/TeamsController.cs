using FutMania.Application.Repositories;
using FutMania.Persistance.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FutMania.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IPlayerReadRepository _playerReadRepository;
        private readonly IPlayerWriteRepository _playerWriteRepository;


        public TeamsController(IPlayerReadRepository playerReadRepository,IPlayerWriteRepository playerWriteRepository)
        {
            _playerReadRepository = playerReadRepository;
            _playerWriteRepository = playerWriteRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _playerWriteRepository.AddRangeAsync(new(){
                new(){Id=Guid.NewGuid(),Name="Edin",LastName="Dzeko",Info="",CreatedAt=DateTime.UtcNow}
            });
            await _playerWriteRepository.SaveAsync();
            return Ok();
        }
    }
}