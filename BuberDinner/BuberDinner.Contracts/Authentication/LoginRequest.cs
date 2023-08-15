namespace BuberDinner.Constrants.Authentication;
public record LoginRequest
(
    string Email,
    string Password
);