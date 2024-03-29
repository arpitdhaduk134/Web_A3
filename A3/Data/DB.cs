using System;
 using Microsoft.EntityFrameworkCore;

public class DB : DbContext
{
    public DB(DbContextOptions<DB> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Order> Orders { get; set; }

}
