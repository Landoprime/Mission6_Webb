using Microsoft.EntityFrameworkCore;

namespace Mission6_LandonWebb.Models
{
    public class Mission6Context : DbContext
    {
        public Mission6Context(DbContextOptions<Mission6Context> options) : base (options)
        {
        } //Constructor

        public DbSet<Movie> Movies { get; set; } 
        public DbSet<Category> Categories { get; set; }

    }
}
