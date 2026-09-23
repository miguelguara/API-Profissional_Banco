using Microsoft.EntityFrameworkCore;
using Mbank.Infrastructure.Data.Context;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Infrastructure.Repositories;
using Mbank.Core.Interfaces.Aplications;
using Mbank.Application.Applications;
using Mbank.Application.Validators;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("ConexaoBanco")));
builder.Services.AddScoped<IclienteRepository, ClienteService>();
builder.Services.AddScoped<ICadastroClienteApp, CadastrarCAplication>();
builder.Services.AddValidatorsFromAssemblyContaining<CadastrarClienteValidation>();


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
