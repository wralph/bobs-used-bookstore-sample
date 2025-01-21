using Aspire.Hosting;
using Microsoft.Extensions.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var booksDb = builder.AddSqlServer("BookstoreDbDefaultConnection");

builder.AddProject("web", "../Bookstore.Web/Bookstore.Web.csproj")
    .WithReference(booksDb);

await builder.Build().RunAsync();