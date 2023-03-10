// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_crofth.Models;

namespace Mission06_crofth.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230214072333_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_crofth.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Family",
                            Director = "Andrew Stanton",
                            Edited = false,
                            Rating = "G",
                            Title = "WALL-E",
                            Year = 2008
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Drama",
                            Director = "Rian Johnson",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Knives Out",
                            Year = 2019
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Drama",
                            Director = "Damien Chazelle",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "La La Land",
                            Year = 2016
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
