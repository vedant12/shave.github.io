using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ReminderShaveBlazor.Models;

namespace ReminderShaveBlazor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Shave> Shaves { get; set; }
    }
}
