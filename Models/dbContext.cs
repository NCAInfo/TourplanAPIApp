
using Microsoft.EntityFrameworkCore;

public class dbContext :DbContext
    {
    public dbContext(DbContextOptions<dbContext> options) : base(options)
    {
    }

    public DbSet<RequestSetRate> RequestSetRate { get; set; }
    public DbSet<Cancellation> Cancellation { get; set; }
    }

