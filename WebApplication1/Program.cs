var builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

var people = new List<Person>
{
  new("Tom", "Hanks"),
  new("Denzel", "Washington"),
  new("Leonardo", "DiCaprio"),
  new("Al", "Pacino"),
  new("Morgan", "Freeman")
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/person", () => new Person("Andrew", "Lock"));

app.MapGet("/people/{name}", (string name) =>
{
  Console.WriteLine($"Received name: '{name}'");
  return people.Where(p => p.FirstName.StartsWith(name, StringComparison.OrdinalIgnoreCase));
});

app.Run();

public record Person(string FirstName, string LastName);
