using Aspire.Hosting;
using var builder = DistributedApplication.CreateBuilder(args);

var booksDb = builder.AddSqlServer("BookstoreDbDefaultConnection")
    .AddDatabase("BookstoreDb");

var web = builder.AddProject("web", "../Bookstore.Web/Bookstore.Web.csproj")
    .WithReference(booksDb);

await builder.BuildAsync();