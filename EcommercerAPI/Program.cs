using EcommercerAPI.Context;
using EcommercerAPI.Interfaces;
using EcommercerAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);
// O .NET faz
// Objetos de inje��o de depend�ncia:
// AddTransient: Cria uma nova inst�ncia do servi�o toda vez que ele � solicitado.
// AddScoped: Cria uma nova inst�ncia/Repository do servi�o por solicita��o dentro de um escopo (por exemplo, durante uma requisi��o HTTP). ou um Controller.
// AddSingleton: Cria uma �nica inst�ncia do servi�o que � compartilhada entre todas as solicita��es.
// AddDbContext: Registra um contexto de banco de dados com um ciclo de vida espec�fico (geralmente Scoped).

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddScoped<EcommerceContext, EcommerceContext>();

builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IPagamentoRepository, PagamentoRepository>();


var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.MapControllers();

app.Run();

