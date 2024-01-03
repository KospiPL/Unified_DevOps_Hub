using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Unified_DevOps_Hub.Class;

var builder = WebApplication.CreateBuilder(args);

// Dodanie DbContext do us³ug
builder.Services.AddDbContext<UzytkownicyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UzytkownicyContext")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();