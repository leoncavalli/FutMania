using FutMania.Application.DTOs;

namespace FutMania.Application.Interfaces;

public interface ITokenHandler
{
    Token CreateAccessToken();
}
