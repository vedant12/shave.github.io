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

        public async Task<PagedResult<Shave>> GetShavesAsync(int pageIndex, int pageSize)
        {
            var query = Shaves.AsQueryable();

            var total = await query.CountAsync();
            var items = await query
                .OrderByDescending(s => s.ShavedOn) // optional sorting
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<Shave>
            {
                Items = items,
                TotalCount = total,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
        }
    }
}
