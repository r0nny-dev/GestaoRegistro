using GestaoRegistro.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoRegistro.Infrastructure.Data;

public class DatabaseContext : DbContext
{
    //public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    //{ }

    private readonly IConfiguration _configuration;
    public DatabaseContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
}
