var builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapGet("/", () => "Hello World!");
app.MapGet("/error", () => "Sorry, error occurred.");

app.Run();
