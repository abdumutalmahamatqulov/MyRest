using Microsoft.EntityFrameworkCore;
using MyRest.Entities;

namespace MyRest.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
    public DbSet<Users> Users { get; set; }
    public DbSet<Course> courses { get; set; }
}
