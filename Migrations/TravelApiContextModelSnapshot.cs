﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Solution.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    partial class TravelApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Rating");

                    b.Property<string>("Review");

                    b.Property<string>("user_name");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            Name = "Seattle",
                            Rating = 5,
                            Review = "It's cool",
                            user_name = "Bob"
                        },
                        new
                        {
                            DestinationId = 2,
                            Name = "San Francisco",
                            Rating = 4,
                            Review = "It's Busy",
                            user_name = "Bob"
                        },
                        new
                        {
                            DestinationId = 3,
                            Name = "New York",
                            Rating = 3,
                            Review = "Way too many people",
                            user_name = "Joe"
                        },
                        new
                        {
                            DestinationId = 4,
                            Name = "Seattle",
                            Rating = 5,
                            Review = "It's pretty neat",
                            user_name = "Joe"
                        },
                        new
                        {
                            DestinationId = 5,
                            Name = "Seattle",
                            Rating = 2,
                            Review = "It's meh",
                            user_name = "Fred"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
