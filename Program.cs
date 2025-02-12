using Best.Data;
using Microsoft.Data.SqlClient;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString = Environment.GetEnvironmentVariable("bestAPI")!;

builder.Services.AddScoped<IDbConnection>(sp => new SqlConnection(connectionString));

builder.Services.AddSingleton(new BestRepository(connectionString));

var app = builder.Build();

app.MapGet("/", (BestRepository repository) =>
{
    var best = repository.GetBest();
    return Results.Json(best);
});

app.Run();