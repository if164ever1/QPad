using Microsoft.EntityFrameworkCore;
using QPadBackend.Models;

namespace QPadBackend.Data
{
    public class QPadDbContext : DbContext
    {
        public QPadDbContext(DbContextOptions<QPadDbContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>()
                .HasOne(n => n.User)
                .WithMany(u => u.Notes)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
