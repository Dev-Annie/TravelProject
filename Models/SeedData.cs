////using Microsoft.EntityFrameworkCore;
//using TravelProject.Models;
// public class Context : DbContext
//{ 
//protected override void OnConfiguring(DbContextOptionsBuilder options)
//{
//    options.UseSqlite(@"Data Source=app.db );

//protected override void OnModelCreating(DbContextOptionsBuilder options(ModelBuilder modelBuilder)
////{
////    modelBuilder.Entity<Parky>().HasData("Parky");
////    modelBuilder.Entity<Parky>()
////        .Property(s => s.Fee)
////        .IsRequired(false);
////    modelBuilder.Entity<Parky>()
////        .Property(s => s.City)
////        .HasDefaultValue(true);

////    modelBuilder.Entity<Parky>()
////        .HasData(
////                new Parky
////                {
////                    Parkname = "Iguanita Wildlife Refuge",
////                    City = "Iguanita",
////                    Fee = 5
////                },

////                new Parky
////                {
////                    Parkname = "Barbilla National Park",
////                    City = " Turrialba",
////                    Fee = 5
////                },

////                new Parky
////                {
////                    Parkname = "Agua Juan Castro Blanco National Park ",
////                    City = "San Carlos",
////                    Fee = 10
////                },

////                new Parky
////                {
////                    Parkname = "Piedras Blancas National Park",
////                    City = " Puntarenas Province",
////                    Fee = 10
////                }
////                );

////    }



