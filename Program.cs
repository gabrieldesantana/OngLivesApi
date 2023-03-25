using ONGLIVES.API.Persistence.Context;
using ONGLIVESAPI.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Context
builder.Services.AddSingleton<OngLivesContext>();


//Services
builder.Services.AddScoped<IOngService,OngService>();
builder.Services.AddScoped<IVoluntarioService,VoluntarioService>();
builder.Services.AddScoped<IVagaService,VagaService>();

//Repository
builder.Services.AddScoped<IVoluntarioRepository,VoluntarioRepository>();



builder.Services.AddApiVersioning();

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
