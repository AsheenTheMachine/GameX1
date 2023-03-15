namespace GameX1.Domain.Helpers;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class DataContext : DbContext
{
    protected readonly IConfigurationRoot configuration;

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        configuration = new ConfigurationBuilder()
        .SetBasePath(System.AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile("appsettings.json")
        .Build();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite(configuration.GetConnectionString("GameX1 Database"));

    public DbSet<Picture> Picture { get; set; }

}

