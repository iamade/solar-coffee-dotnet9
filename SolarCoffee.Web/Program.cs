using Microsoft.EntityFrameworkCore;
using SolarCoffee.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SolarDbContext>(opts =>
{
    opts.EnableDetailedErrors();
    opts.UseNpgsql(builder.Configuration.GetConnectionString("solar.dev"));
});

var app = builder.Build();

app.UseHttpsRedirection();


app.Run();
