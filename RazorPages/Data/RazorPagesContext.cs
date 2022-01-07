namespace RazorPages.Data
{
    public class RazorPagesContext : DbContext
    {
        public RazorPagesContext (DbContextOptions<RazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
