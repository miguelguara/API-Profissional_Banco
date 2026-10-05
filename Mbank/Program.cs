using Microsoft.EntityFrameworkCore;
using Mbank.Infrastructure.Data.Context;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Infrastructure.Repositories;
using Mbank.Application.Applications;
using FluentValidation;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using Mbank.Core.Interfaces.Aplications.Clientes;
using Mbank.Application.Validators.Cliente;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

//Adiciona o swagger e a conexão com o banco de dados;
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("ConexaoBanco")));
builder.Services.AddScoped<IclienteRepository, ClienteService>();
builder.Services.AddScoped<ICadastroClienteApp, CadastrarCAplication>();
builder.Services.AddScoped<IAlterarClienteApp, AlterarClienteAplication>();
builder.Services.AddValidatorsFromAssemblyContaining<CadastrarClienteValidation>();
builder.Services.AddValidatorsFromAssemblyContaining<AlterarClienteValidator>();

builder.Services.AddFluentValidationAutoValidation();


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
