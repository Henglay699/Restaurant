var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication().AddBearerToken();
builder.Services.AddAuthorization();

var app = builder.Build();

app.MapGet("/", () => "Hello World!")
.RequireAuthorization();

app.Run();
