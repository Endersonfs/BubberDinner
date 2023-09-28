using BuberDinner.Application.Common.Interface.Authentication;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwTokenGenerator _jwTokenGenerator;

    public AuthenticationService(IJwTokenGenerator jwTokenGenerator)
    {
        _jwTokenGenerator = jwTokenGenerator;
    }
    public AuthenticationResult Login(string Email, string Password)
    {
        //
       return new AuthenticationResult(Guid.NewGuid(), "FirstName","LastName",Email, "Tokend");
    }

    public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
    {
        //Check if user already exist
        var userId = Guid.NewGuid();
        //Create user (generate unique ID)
        var token =_jwTokenGenerator.GenerateToken(userId,FirstName, LastName);
        //Create JWT
       return new AuthenticationResult(Guid.NewGuid(), FirstName,LastName,Email, token);
    }
}