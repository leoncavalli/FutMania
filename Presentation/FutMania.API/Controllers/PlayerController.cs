using FutMania.Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutMania.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PlayerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // [HttpPost]
        // public async Task<IActionResult> AddPlayer(Player player)
        // {
        //     await _playerService.AddPlayer(player);
        //     return Ok();
        // }
        // 
        [HttpGet]
        public IActionResult GetPlayers()
        {
            var players = _mediator.Send(new GetAllPlayersQueryRequest());
            return Ok(players);
        }


   }
}