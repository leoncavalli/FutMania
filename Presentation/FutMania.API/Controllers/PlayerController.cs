using FutMania.Application.Operations.Commands.AddPlayer;
using FutMania.Application.Operations.Commands.DeletePlayer;
using FutMania.Application.Operations.Commands.UpdatePlayer;
using FutMania.Application.Operations.Queries.GetAllPlayers;
using FutMania.Application.Operations.Queries.GetPlayerById;

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
        
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetPlayer([FromRoute] GetPlayerByIdRequest getPlayerByIdRequest)
        {
            var player = await _mediator.Send(getPlayerByIdRequest);
            return Ok(player);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeletePlayer([FromRoute]  DeletePlayerCommandRequest deletePlayerCommandRequest)
        {
            await _mediator.Send(deletePlayerCommandRequest);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePlayer([FromRoute]  UpdatePlayerCommandRequest updatePlayerCommandRequest)
        {
            await _mediator.Send(updatePlayerCommandRequest);
            return Ok();
        }



   }
}