using Microsoft.EntityFrameworkCore;
using DAL.Models;
using System.Runtime.CompilerServices;


namespace DAL
{
    internal class CarpoolingDbContext : DbContext
    {
        DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>();
        }
    }
}
