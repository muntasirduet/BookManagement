using BookManagement.Model;
using BookManagement.Model.Models;
using BookManagement.Model.Models.FluentModels;
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
    
    
    
    //fluent api
    public DbSet<Fluent_Author> Fluent_Author { get; set; }
    public DbSet<Fluent_Book> Fluent_Books { get; set; }
    public DbSet<Fluent_BookAuthorMap> Fluent_BookAuthorMap { get; set; }
    public DbSet<Fluent_BookDetail> Fluent_BookDetail { get; set; }
    public DbSet<Fluent_Publisher> Fluent_Publisher { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Server=localhost,1433; Database=BookApp; User=sa; Password =muntasir@123; Trusted_Connection=false; TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Fluent_BookDetail>().Property(u => u.NumberOfChapter).IsRequired();
        modelBuilder.Entity<Fluent_BookDetail>().HasKey(u => u.BookDetail_Id);
        //author id
        modelBuilder.Entity<Fluent_Author>().Property(u => u.FirstName).IsRequired();
        modelBuilder.Entity<Fluent_Author>().HasKey(u => u.Author_Id);
        modelBuilder.Entity<Fluent_Author>().Property(u => u.FirstName).HasMaxLength(50);
        modelBuilder.Entity<Fluent_Author>().Ignore(u => u.FullName);
        //flueint book
        modelBuilder.Entity<Fluent_Book>().HasKey(u => u.IDBook);
        modelBuilder.Entity<Fluent_Book>().Property(u => u.IDBook).HasColumnName("Book_Id");
        modelBuilder.Entity<Fluent_Book>().Ignore(u => u.PriceRange);
        //Fluent_BookAuthorMap
        modelBuilder.Entity<Fluent_BookAuthorMap>().HasKey(u => new { u.Author_Id, u.Book_Id });
        //publisher
        modelBuilder.Entity<Fluent_Publisher>().HasKey(u => u.Publisher_Id); 
        
        
        //one - one 
        modelBuilder.Entity<Fluent_BookDetail>().HasOne(b => b.Book)
            .WithOne(b => b.FluentBookDetail)
            .HasForeignKey<Fluent_BookDetail>("Book_Id");
        
        
        modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);
        modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.Author_Id, u.Book_Id });
    }
}