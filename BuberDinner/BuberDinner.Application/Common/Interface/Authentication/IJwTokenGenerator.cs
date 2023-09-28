namespace BuberDinner.Application.Common.Interface.Authentication;
public interface IJwTokenGenerator
{
    string GenerateToken(Guid userId, string firstName, string lastName);
}
