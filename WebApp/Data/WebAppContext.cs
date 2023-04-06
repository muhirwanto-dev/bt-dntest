using Microsoft.EntityFrameworkCore;
using WebApp.Model;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext (DbContextOptions<WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp.Model.AuthData> AuthData { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthData>().ToTable("AuthData");
            modelBuilder.Entity<Checklist>().ToTable("Checklist");
            modelBuilder.Entity<ChecklistItem>().ToTable("ChecklistItem");
        }
    }
}
