using Microsoft.EntityFrameworkCore;
using Projet.Entities;

namespace Projet.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Cheque> Cheques { get; set; }
    }
}
