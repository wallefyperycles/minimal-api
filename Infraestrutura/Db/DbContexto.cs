using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.Infraestrutura.Db;

public class DbContexto : DbContext
{
    private readonly IConfiguration _configuracaoAppSettings;

    //construtor
    public DbContexto(IConfiguration configuracaoAppSettings) // injeção de dependencia, o IConfiguration é um container que serve para ler o que tem dentro do appsettings.json e colocar na variável.
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }
    public DbSet<Administrador> Administradores{get; set;} = default!;
    public DbSet<Veiculo> Veiculos {get; set;} = default!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>().HasData(
            new Administrador
            {
                Id = 1,
                Email = "administrador@teste.com",
                Senha = "123456",
                Perfil = "Adm"
            }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var stringConexao = _configuracaoAppSettings.GetConnectionString("MySql")?.ToString(); // a interrogação é para caso nao achar nada vem vazio;
            if (!string.IsNullOrEmpty(stringConexao))
            {
            optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
            }
        
        }
        
    }
}