using ActorMaster.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ActorMaster.Data
{
    public class ActorMasterContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Actors");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>()
               .HasData(new Actor()
               {
                   Id = 1,
                   CustomerNo = 10011,
                   Name = "Liten fisk",
                   Type = Enums.ActorType.Reseller
               },
               new Actor()
               {
                   Id = 2,
                   CustomerNo = 10054,
                   Name = "Blå sykkel",
                   Type = Enums.ActorType.Private
               }
               );
        }
    }
}