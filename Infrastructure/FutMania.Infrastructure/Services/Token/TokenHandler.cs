using System.IdentityModel.Tokens.Jwt;
using System.Text;
using FutMania.Application.DTOs;
using FutMania.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace FutMania.Infrastructure.Services;

public class TokenHandler : ITokenHandler
{
    private readonly IConfiguration _configuration;

    public TokenHandler(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public Token CreateAccessToken()
    {
        Token token = new();
        SymmetricSecurityKey symmetricSecurityKey = new(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"]));
        SigningCredentials signingCredentials = new(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
        token.Expiration = DateTime.UtcNow.AddMinutes(15);
        JwtSecurityToken securityToken = new(
            audience: _configuration["Token:Audience"], 
            issuer: _configuration["Token:Issuer"], 
            expires: token.Expiration, 
            notBefore: DateTime.UtcNow, 
            signingCredentials: signingCredentials);
        JwtSecurityTokenHandler tokenHandler = new();
        token.AccessToken = tokenHandler.WriteToken(securityToken);
        return token;
    }
}
