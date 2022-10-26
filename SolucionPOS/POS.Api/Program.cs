using POS.Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureServices(builder.Configuration);

var app = builder.Build();
app.ConfigureApplication(app.Environment);
app.Run();
