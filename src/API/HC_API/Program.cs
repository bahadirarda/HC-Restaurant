using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using System.Net;
using Newtonsoft.Json;
using HC_API.Utils.Interface;
using HC_API.Middleware;
using HC_API.Utils.Concrete;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));



builder.Services.AddControllers();
builder.Services.AddSingleton<ILoggerService, FileLogger>();

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

//Middleware Dependency Injection
app.UseCustomExceptionHandler();

app.UseAuthorization();

app.MapControllers();

app.Run();
