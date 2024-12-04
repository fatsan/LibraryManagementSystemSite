

using LibraryManagementSystemSite.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystemSite.Repository.Contexts;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions opt) : base(opt)
    {
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
}
