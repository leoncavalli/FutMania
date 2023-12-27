using MediatR;

namespace FutMania.Application.Operations.Queries.GetPlayerById;

public class GetPlayerByIdRequest : IRequest<GetPlayerByIdResponse>
{
    public string Id { get; set; }

}
