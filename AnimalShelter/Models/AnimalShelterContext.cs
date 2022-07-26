using Microsoft.EntityFrameeworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : AddDbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterContext(DbContextOptions options) : base(options) { }
  }
}