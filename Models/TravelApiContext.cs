using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public TravelApiContext(DbContextOptions<TravelApiContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Destination>()
              .HasData(
              new Destination { DestinationId = 1, Name = "Seattle", Review = "It's cool", Rating = 5, user_name = "Bob" },
              new Destination { DestinationId = 2, Name = "San Francisco", Review = "It's Busy", Rating = 4, user_name = "Bob" },
              new Destination { DestinationId = 3, Name = "New York", Review = "Way too many people", Rating = 3, user_name = "Joe" },
              new Destination { DestinationId = 4, Name = "Seattle", Review = "It's pretty neat", Rating = 5, user_name = "Joe" },
              new Destination { DestinationId = 5, Name = "Seattle", Review = "It's meh", Rating = 2, user_name = "Fred" }

              );
        }

        public DbSet<Destination> Destinations { get; set; }
    }
}
