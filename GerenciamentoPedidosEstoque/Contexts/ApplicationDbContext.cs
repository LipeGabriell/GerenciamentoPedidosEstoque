using System.Data.Common;
using System.Net.Sockets;
using GerenciamentoPedidosEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoPedidosEstoque.Contexts;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    DbSet<Client> Clientes { get; set; }
    DbSet<Product> Produtos { get; set; }
    DbSet<Request> Pedidos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Client>().HasIndex(c => new { c.Id, c.Email }).IsUnique();
        modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");
        modelBuilder.Entity<Client>().HasOne(c => c.Address);
    }
}