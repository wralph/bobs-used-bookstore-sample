using Aspire.Hosting;

var builder = Aspire.Hosting.DistributedApplication.CreateBuilder(args);

var booksDb = builder.AddSqlServer("BookstoreDbDefaultConnection");

builder.AddProject("web", "../Bookstore.Web/Bookstore.Web.csproj")
    .WithReference(booksDb);

builder.Build().Run();