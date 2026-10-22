using Microsoft.EntityFrameworkCore;
using Mbank.Infrastructure.Data.Context;
using Mbank.Core.Interfaces.Repositories;
using Mbank.Infrastructure.Repositories;
using FluentValidation;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using Mbank.Core.Interfaces.Aplications.Clientes;
using Mbank.Application.Validators.Cliente;
using Mbank.Application.Applications.ClientesAP;
using Mbank.Core.Interfaces.Aplications.TransacoesAP;
using Mbank.Application.Applications.TransacoesAP;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


//Adiciona o swagger e a conexão com o banco de dados;
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("ConexaoBanco")));

//Injeções de dependencia
builder.Services.AddScoped<IclienteRepository, ClienteService>();
builder.Services.AddScoped<ICadastroClienteApp, CadastrarCAplication>();
builder.Services.AddScoped<IAlterarClienteApp, AlterarClienteAplication>();
builder.Services.AddScoped<IenderecoRepository, EnderecoService>();
builder.Services.AddScoped<IcarteiraRepository, CarteiraService>();
builder.Services.AddScoped<ItransacaoRepository, TransacaoService>();
builder.Services.AddScoped<IcofrinhoRepository, CofrinhoServices>();
builder.Services.AddScoped<ItransacaoApp, TransacaoAplication>();



//validators
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
