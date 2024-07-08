using Microsoft.AspNetCore.Builder;
using Bookstore.Web.Startup;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.AddServiceDefaults();

builder.AddSqlServerClient("Bookstore");

builder.ConfigureConfiguration();

builder.ConfigureServices();

builder.ConfigureAuthentication();

builder.ConfigureDependencyInjection();

var app = builder.Build();

await app.ConfigureMiddlewareAsync();

app.Run();