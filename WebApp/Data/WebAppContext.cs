using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext (DbContextOptions<WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp.Model.AuthData> AuthData { get; set; } = default!;
    }
}
