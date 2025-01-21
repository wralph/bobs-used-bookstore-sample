using Aspire.Hosting;

var builder = DistributedApplicationBuilder.CreateBuilder(args);

var booksDb = builder.AddSqlServer("BookstoreDbDefaultConnection");

builder.AddProject<Projects.Bookstore_Web>("web")
    .WithReference(booksDb);

builder.Build().Run();