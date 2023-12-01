using Microsoft.EntityFrameworkCore;
using QPadBackend.Models;

namespace QPadBackend.Data
{
    public class QPadDbContext : DbContext
    {
        public QPadDbContext(DbContextOptions<QPadDbContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}
