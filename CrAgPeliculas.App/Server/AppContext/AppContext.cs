using Microsoft.EntityFrameworkCore;
using CrAgPeliculas.App.Shared.Entity;

namespace CrAgPeliculas.App.Server
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategory>().HasKey( x => new { x.MovieId, x.CategoryId } );
            modelBuilder.Entity<StaffMovie>().HasKey( x => new { x.StaffId, x.MovieId } );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Person> PersonTB {  get; set; }
        public DbSet<Movie> MovieTB {  get; set; }
        public DbSet<Staff> StaffTB {  get; set; }
        public DbSet<Category> CategoryTB {  get; set; }
        public DbSet<User> UserTB {  get; set; }
        public DbSet<MovieCategory> MovieCategoryTB{  get; set; }
        public DbSet<StaffMovie> StaffMovieTB {  get; set; }
    }
}