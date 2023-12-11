using FutMania.Application.Repositories;
using FutMania.Domain.Entities;
using MediatR;

namespace FutMania.Application;

public class AddPlayerCommandHandler : IRequestHandler<AddPlayerCommandRequest, AddPlayerCommandResponse>
{
    readonly IPlayerWriteRepository _playerWriteRepository;
    public AddPlayerCommandHandler(IPlayerWriteRepository playerWriteRepository)
    {
        _playerWriteRepository = playerWriteRepository;
    }
    public async Task<AddPlayerCommandResponse> Handle(AddPlayerCommandRequest request, CancellationToken cancellationToken)
    {
        Player player = new() { Name = request.Name, LastName = request.LastName, Info = request.Info };
        await _playerWriteRepository.AddAsync(player);
        await _playerWriteRepository.SaveAsync();
        return new AddPlayerCommandResponse() { Status = "Done" };
    }
}
