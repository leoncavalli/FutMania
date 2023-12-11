using MediatR;

namespace FutMania.Application;

public class AddPlayerCommandRequest : IRequest<AddPlayerCommandResponse>
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Info { get; set; }

}
