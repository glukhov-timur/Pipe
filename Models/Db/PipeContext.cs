using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Pipe.Models.Db
{
    internal class PipeContext : DbContext
    {
        public DbSet<PipeModel> Pipes { get; set; }
        public DbSet<Steel> Steels { get; set; }
        public DbSet<Packet> Packets { get; set; }

        public PipeContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=pipe.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Steel>().HasData(
                new Steel() { Id = 1, SteelName = "09Г2С" },
                new Steel() { Id = 2, SteelName = "Ст10" },
                new Steel() { Id = 3, SteelName = "Ст20" },
                new Steel() { Id = 4, SteelName = "Ст35" },
                new Steel() { Id = 5, SteelName = "Ст45" },
                new Steel() { Id = 6, SteelName = "13ХФА" },
                new Steel() { Id = 7, SteelName = "17Г1С" },
                new Steel() { Id = 8, SteelName = "08Г2С" },
                new Steel() { Id = 9, SteelName = "12ГН2МФАЮ" }
                );

            modelBuilder.Entity<Packet>().HasData(
                new Packet() { Id = 1, PacketNumber = 1234, PacketDate = DateTime.Now.AddDays(-3) },
                new Packet() { Id = 2, PacketNumber = 1235, PacketDate = DateTime.Now.AddDays(-2) },
                new Packet() { Id = 3, PacketNumber = 1236, PacketDate = DateTime.Now.AddDays(-1) }
                );

            modelBuilder.Entity<PipeModel>().HasData(
                new PipeModel { Id = 1, Number = 111111, IsDefective = false, SteelId = 1, Diameter = 200, Thickness = 6, Length = 5000, Weight = 20 },
                new PipeModel { Id = 2, Number = 111112, IsDefective = true, SteelId = 1, Diameter = 200, Thickness = 6, Length = 5000, Weight = 20 },
                new PipeModel { Id = 3, Number = 111113, IsDefective = true, SteelId = 1, Diameter = 200, Thickness = 6, Length = 5000, Weight = 20 },
                new PipeModel { Id = 4, Number = 111114, IsDefective = false, SteelId = 4, Diameter = 100, Thickness = 4, Length = 5000, Weight = 20 },
                new PipeModel { Id = 5, Number = 111115, IsDefective = false, SteelId = 5, Diameter = 200, Thickness = 6, Length = 5000, Weight = 20 },
                new PipeModel { Id = 6, Number = 111116, IsDefective = true, SteelId = 6, Diameter = 300, Thickness = 6, Length = 5000, Weight = 20 },
                new PipeModel { Id = 7, Number = 111117, IsDefective = false, SteelId = 7, Diameter = 200, Thickness = 6, Length = 5000, Weight = 20 },
                new PipeModel { Id = 8, Number = 111118, IsDefective = false, SteelId = 7, Diameter = 400, Thickness = 6, Length = 5000, Weight = 20 },
                new PipeModel { Id = 9, Number = 111119, IsDefective = false, SteelId = 8, Diameter = 200, Thickness = 6, Length = 5000, Weight = 20 },
                new PipeModel { Id = 10, Number = 111120, IsDefective = false, SteelId = 9, Diameter = 200, Thickness = 6, Length = 5000, Weight = 20 }
                );

            
        }
    }
}
