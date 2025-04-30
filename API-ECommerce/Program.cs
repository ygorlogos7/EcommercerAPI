using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Repositories;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

// O .NET vai criar os objetos (Inje��o de Dependencia)
// AddTransient - O C# criar uma instancia nova, toda vez que um m�todo � chamado
// AddScoped - O C# cria uma instancia nova, toda vez que criar um Controller
// AddSingleton
builder.Services.AddDbContext<EcommerceContext>();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IPagamentoRepository, PagamentoRepository>();
builder.Services.AddTransient<IItemPedidoRepository, ItemPedidoRepository>();
builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();

builder.Services.AddAuthentication("Bearer") // Tipo de autentica��o
    .AddJwtBearer("Bearer", options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters // Par�metros de valida��o do token
        {
            // Valida��es
            ValidateIssuer = true, // Valida o emissor
            ValidateAudience = true, // Valida o p�blico
            ValidateLifetime = true, // Valida o tempo de expira��o
            ValidateIssuerSigningKey = true,
            ValidIssuer = "API_ECommerce", // Emissor
            ValidAudience = "API_ECommerce", // P�blico
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("chave-secreta-original-para-seguranca-da-aplicacao"))
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.MapControllers();

app.UseAuthentication(); 
app.UseAuthorization();

app.Run();