using Microsoft.AspNetCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.UseMiddleware<WelcomePageMiddleware>();

app.Run();
