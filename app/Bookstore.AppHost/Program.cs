using Aspire.Hosting;
using Aspire.Hosting.Sql;

var builder = DistributedApplication.CreateBuilder(args);

var booksDb = builder.AddSqlServer("BookstoreDbDefaultConnection");

builder.AddProject("web", "../Bookstore.Web/Bookstore.Web.csproj")
    .WithReference(booksDb);

builder.Build().Run();