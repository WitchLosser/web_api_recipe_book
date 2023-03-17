using Core.Helpers;
using Core.Interfaces;
using Core.Services;
using Infrustructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using web_api_recipe_book;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

string connStr = builder.Configuration.GetConnectionString("LocalDb");

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//add jwt and SwaggerConfigurations
builder.Services.AddJWT(builder.Configuration);
builder.Services.AddSwaggerGenConfigurations();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext(connStr);
builder.Services.AddIdentity();


builder.Services.AddRepository();
builder.Services.AddCustomServices();


// add auto mapper
builder.Services.AddAutoMapper();
// add fluent validators
builder.Services.AddValidators();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
