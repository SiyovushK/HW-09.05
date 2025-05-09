using CookiesWithMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CookiesWithMvc.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<User> Users => Set<User>();
}