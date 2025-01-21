using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var booksDb = builder.AddSqlServer("BookstoreDbDefaultConnection");

builder.AddProject("web", "../Bookstore.Web/Bookstore.Web.csproj")
    .WithReference(booksDb);

await builder.Build().RunAsync();