using Microsoft.EntityFrameworkCore;

namespace Clair.Models
{
  public class SalonContext : DbContext
  {
    public DbSet<Client> Clients { get; set; }

    public SalonContext(DbContextOptions options) : base(options) { }
  }
}