using EcommercerAPI.Context;
using EcommercerAPI.Interfaces;
using EcommercerAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);
// O .NET faz
// Objetos de injeção de dependência:
// AddTransient: Cria uma nova instância do serviço toda vez que ele é solicitado.
// AddScoped: Cria uma nova instância/Repository do serviço por solicitação dentro de um escopo (por exemplo, durante uma requisição HTTP). ou um Controller.
// AddSingleton: Cria uma única instância do serviço que é compartilhada entre todas as solicitações.
// AddDbContext: Registra um contexto de banco de dados com um ciclo de vida específico (geralmente Scoped).

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

