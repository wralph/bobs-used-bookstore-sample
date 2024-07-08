using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var booksDb = builder.AddSqlServer("sqlserver");

builder.AddProject<Projects.Bookstore_Web>("web")
    .WithReference(booksDb);

builder.Build().Run();
