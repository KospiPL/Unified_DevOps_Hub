using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Unified_DevOps_Hub.Api.Unified_DevOps_Hub.Api.Dbcontxt;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<UzytkownicyContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("UzytkownicyContext");
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
