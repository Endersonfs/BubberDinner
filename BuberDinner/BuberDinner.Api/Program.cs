using BuberDinner.Application.Services.Authentication;

var builder = WebApplication.CreateBuilder(args);
{
   // Add services to the container. 
    builder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();
    builder.Services.AddControllers();
}

var app = builder.Build();

{    
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
