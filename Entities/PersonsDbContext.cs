using Microsoft.EntityFrameworkCore;

namespace Entities;

public class PersonsDbContext : DbContext
{
  public PersonsDbContext(DbContextOptions options) : base(options)
  {
  }

  public DbSet<Country> Countries { get; set; }
  public DbSet<Person> Persons { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Country>().ToTable("Countries");
    modelBuilder.Entity<Person>().ToTable("Persons");
  }
}