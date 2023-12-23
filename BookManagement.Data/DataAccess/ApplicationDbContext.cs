using BookManagement.Model;
using BookManagement.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Data.DataAccess;

public class ApplicationDbContext:DbContext
{
    public DbSet<Book> Books { get; set; }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<BookDetail> BookDetails { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Server=localhost,1433; Database=BookApp; User=sa; Password =muntasir@123; Trusted_Connection=false; TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);
        
    }
}