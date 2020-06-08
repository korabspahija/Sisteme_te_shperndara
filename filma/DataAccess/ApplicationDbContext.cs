using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<ChatHistory> ChatHistories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
