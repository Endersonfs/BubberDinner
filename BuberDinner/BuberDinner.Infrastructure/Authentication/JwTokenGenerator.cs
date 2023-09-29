using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BuberDinner.Application.Common.Interface.Authentication;
using BuberDinner.Application.Common.Interface.Service;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BuberDinner.Infrastructure.Authentication;
public class JwTokenGenerator : IJwTokenGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly JwSetting _jwSetting;
    public JwTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwSetting> jwSetting)
    {
        _dateTimeProvider = dateTimeProvider;
        _jwSetting = jwSetting.Value;
    }
    string IJwTokenGenerator.GenerateToken(Guid userId, string firstName, string lastName)
    {
        var signingCredential = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwSetting.Secret)),
            SecurityAlgorithms.HmacSha256
        );

        var claim  = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };
        var securityToken = new JwtSecurityToken(
            issuer: _jwSetting.Issuer,
            expires : _dateTimeProvider.UtcNow.AddMinutes(_jwSetting.ExpiryMinutes),
            claims : claim,
            signingCredentials : signingCredential
        );

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }

}
