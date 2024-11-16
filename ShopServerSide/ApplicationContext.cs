using Microsoft.EntityFrameworkCore;
using ShopServerSide.Model;

namespace ShopServerSide;

public class ApplicationContext: DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Card> Cards { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Client> Clients { get; set; } = null!;
    public DbSet<Favourite> Favourites { get; set; } = null!;
    public DbSet<Notification> Notifications { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<OrderItem> OrderItems { get; set; } = null!;
    public DbSet<Payment> Payments { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;


    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        :base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       // optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ShopDb;Username=postgres;Password=super");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Card>().HasOne(p => p.Client)
            .WithMany(p => p.Cards)
            .HasForeignKey(p => p.ClientId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(p => p.Products)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.SetNull);
        
        modelBuilder.Entity<User>()
            .HasOne(p => p.Client)
            .WithOne(p => p.User)
            .HasForeignKey<Client>(p => p.ClientId);
        
        modelBuilder.Entity<Favourite>().HasKey(p => new { p.ProductId, p.ClientId });
        
        modelBuilder.Entity<Favourite>()
            .HasOne(p => p.Client)
            .WithMany(p => p.Favourites)
            .HasForeignKey(p => p.ClientId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Favourite>()
            .HasOne(p => p.Product)
            .WithMany(p => p.Favourites)
            .HasForeignKey(p => p.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Review>()
            .HasOne(p => p.Client)
            .WithMany(p => p.Reviews)
            .HasForeignKey(p => p.ClientId)
            .OnDelete(DeleteBehavior.SetNull);
        
        modelBuilder.Entity<Review>()
            .HasOne(p => p.Product)
            .WithMany(p => p.Reviews)
            .HasForeignKey(p => p.ProductId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Order>()
            .HasOne(p => p.Payment)
            .WithOne(p => p.Order)
            .HasForeignKey<Payment>(p => p.OrderId);

        modelBuilder.Entity<Order>()
            .HasOne(p => p.Client)
            .WithMany(p => p.Orders)
            .HasForeignKey(p => p.ClientId)
            .OnDelete(DeleteBehavior.SetNull);
        
        modelBuilder.Entity<OrderItem>().HasKey(p => new { p.ProductId, p.OrderId });
        
        modelBuilder.Entity<OrderItem>()
            .HasOne(p => p.Product)
            .WithMany(p => p.OrderItems)
            .HasForeignKey(p => p.ProductId)
            .OnDelete(DeleteBehavior.SetNull);
        
        modelBuilder.Entity<OrderItem>()
            .HasOne(p => p.Order)
            .WithMany(p => p.OrderItems)
            .HasForeignKey(p => p.OrderId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}