using GerenciamentoPedidosEstoque.Contexts;
using GerenciamentoPedidosEstoque.Repositories;
using GerenciamentoPedidosEstoque.Repositories.ClientRepository;
using GerenciamentoPedidosEstoque.Repositories.ProductRepository;
using GerenciamentoPedidosEstoque.Repositories.RequestRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Database

builder.Services.AddSqlite<ApplicationDbContext>("Data Source=./database.db;");
builder.Services.AddScoped<ApplicationDbContext>();

#endregion

#region Repositories

builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IRequestRepository, RequestRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();