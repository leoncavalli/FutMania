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
        [HttpPost]
        public async Task<IActionResult> AddPlayer(AddPlayerCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        
        [HttpGet]
        public IActionResult GetPlayers()
        {
            var players = _mediator.Send(new GetAllPlayersQueryRequest());
            return Ok(players);
        }


   }
}