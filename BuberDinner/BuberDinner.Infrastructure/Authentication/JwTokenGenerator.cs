using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BuberDinner.Application.Common.Interface.Authentication;
using Microsoft.IdentityModel.Tokens;

namespace BuberDinner.Infrastructure.Authentication;
public class JwTokenGenerator : IJwTokenGenerator
{
    string IJwTokenGenerator.GenerateToken(Guid userId, string firstName, string lastName)
    {
        var signingCredential = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Super-Secret-Key-BuberDinnerAppasdfasdfasdfasdfasd")),
            SecurityAlgorithms.HmacSha256
        );

        var claim  = new[]
        {
            new Claim(JwtRegisteredClaimNames.UniqueName, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };
        var securityToken = new JwtSecurityToken(
            issuer: "BuberDinner",
            expires : DateTime.UtcNow.AddDays(1),
            claims : claim,
            signingCredentials : signingCredential
        );

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }

}
