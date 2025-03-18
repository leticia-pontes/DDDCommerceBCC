using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using DDDCommerceBCC.Domain.Entities;

namespace DDDCommerceBCC.Infra.Data;

public class AppDbContext : DbContext
{
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<ItemPedido> ItensPedido { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            Env.Load("../.env");
            //cConsole.WriteLine($"DB_CONNECTION_STRING: {Environment.GetEnvironmentVariable("DB_CONNECTION_STRING")}");
            var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") 
                                   ?? throw new InvalidOperationException("A variável de ambiente DB_CONNECTION_STRING não está definida.");

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}