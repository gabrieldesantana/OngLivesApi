using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using ONGLIVES.API.Persistence.Context;
using ONGLIVESAPI.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<OngLivesContext>();
builder.Services.AddRegisterServices();


// builder.Services.AddApiVersioning(x => 
// {
//     x.DefaultApiVersion = new ApiVersion(1, 0);
//     x.ReportApiVersions = true;
//     x.AssumeDefaultVersionWhenUnspecified = true;
//     }
// ); //

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x => 
{
    x.SwaggerDoc("v1",
    new OpenApiInfo {
        Title = "RESTAPi for OngLives",
                        Version = "v1",
                        Description = "API RESTful developed to a Non Governamental Organization called 'OngLives' ",

                        Contact = new OpenApiContact 
                        {
                            Name = "Gabriel Gomes",
                            Url = new Uri("https://github.com/gabrieldesantana/")
                        }});
});

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



// services.AddSwaggerGen(c => 
//             {
//                 c.SwaggerDoc("v1",
//                     new OpenApiInfo
//                     {
//                         Title = "REST API's From 0 to Azure with ASP.NET Core 5 and Docker",
//                         Version = "v1",
//                         Description = "API RESTful developed in course 'REST API's From 0 to Azure with ASP.NET Core 5 and Docker' ",
//                         Contact = new OpenApiContact 
//                         {
//                             Name = "Gabriel Gomes",
//                             Url = new Uri("https://github.com/gabrieldesantana")
//                         }});
//             });