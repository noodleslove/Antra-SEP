using EntityFramwork.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace EntityFramework.Infrastructure.Data;

public class EfDemoDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var conn = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build()
            .GetConnectionString("EfDemoDb");

        optionsBuilder.UseSqlServer(conn);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Department>((entity) =>
        // {
        //     entity.Property((d) => d.Name).HasColumnType("varchar(20)");
        //     entity.HasKey((d) => d.Id);
        //     entity.HasIndex((d) => d.Name).IsUnique();
        // });
        
        modelBuilder.Entity<Department>(ConfigureDepartment);
    }

    private void ConfigureDepartment(EntityTypeBuilder<Department> entity)
    {
        entity.Property((d) => d.Name).HasColumnType("varchar(20)");
        entity.HasKey((d) => d.Id);
        entity.HasIndex((d) => d.Name).IsUnique();
    }
}