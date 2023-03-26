namespace BookAndPublisher.Models;

using Microsoft.EntityFrameworkCore;


public class BookPublisherDataContext: DbContext
{
    public DbSet<Publisher> Publisher { get; set; } 
    public DbSet<Books> Books { get; set; } 
			
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server =(local); Database = BooksDatabse; User Id=sa; Password=Aa123456;Trust Server Certificate = true");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Books>().HasOne<Publisher>(b => b.BookPublisher).WithMany(g => g.Book)
            .HasForeignKey(b => b.BookPublisherId);
    }
}