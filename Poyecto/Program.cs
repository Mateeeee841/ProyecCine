using Microsoft.EntityFrameworkCore;
using Proyecto;


var builder = WebApplication.CreateBuilder(args);

//Agruego servicio para que haga la conexion a la base de datos
builder.Services.AddDbContext<ConexionesDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("baseDeMateo")));

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
