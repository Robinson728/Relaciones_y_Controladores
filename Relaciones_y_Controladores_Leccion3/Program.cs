using Microsoft.EntityFrameworkCore;
using Relaciones_y_Controladores_Leccion3.DAL;

var builder = WebApplication.CreateBuilder(args);

//- Connection with SQL Server
const string ConnectionName = "ControlsDB";
var connectionString = builder.Configuration.GetConnectionString(ConnectionName);

//- Add Context to services of builder
builder.Services.AddDbContext<ProyectContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
