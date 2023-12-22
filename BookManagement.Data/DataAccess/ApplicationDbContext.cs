using BookManagement.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.Data.DataAccess;

public class ApplicationDbContext:DbContext
{
    public DbSet<Book> Books { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Server=localhost,1433; Database=BookApp; User=sa; Password =muntasir@123; Trusted_Connection=false; TrustServerCertificate=true;");
    }
}