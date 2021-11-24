using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using HTSP.Interaction.Database_Interaction.Configuration;
using Microsoft.EntityFrameworkCore;

namespace HTSP.Interaction.Database_Interaction
{
    public class HTSPDbContext : DbContext, IHTSPDbContext
    {
        DbSet<User> IHTSPDbContext.Users { get; set; }
        DbSet<Account> IHTSPDbContext.Accounts { get; set; }
        DbSet<Order> IHTSPDbContext.Orders { get; set; }
        DbSet<OrderLine> IHTSPDbContext.OrderLines { get; set; }
        DbSet<Article> IHTSPDbContext.Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder DbBuilder)
        {
            DbBuilder.Entity<Account>()
            .HasOne(b => b.User)
            .WithOne(i => i.Account)
            .HasForeignKey<User>(b => b.UserID);
            DbBuilder.Entity<OrderLine>()
            .HasOne(b => b.Article)
            .WithOne(i => i.OrderLine)
            .HasForeignKey<Article>(b => b.ArticleID);
            DbBuilder.Entity<Order>()
            .HasOne(b => b.Account)
            .WithMany(i => i.Orders)
            .HasForeignKey(b => b.OrderId);
            DbBuilder.Entity<OrderLine>()
            .HasOne(b => b.Order)
            .WithMany(i => i.OrderLines)
            .HasForeignKey(b => b.OrderID);

            DbBuilder.ApplyConfiguration(new UserConfigurations());
            DbBuilder.ApplyConfiguration(new AccountConfiguration());
            DbBuilder.ApplyConfiguration(new OrderConfiguration());
            DbBuilder.ApplyConfiguration(new OrderLineConfiguration());
            DbBuilder.ApplyConfiguration(new ArticleConfiguration());
            base.OnModelCreating(DbBuilder);
        }
        public HTSPDbContext(DbContextOptions<HTSPDbContext> DBOptions)
            : base(DBOptions)
        {
            Database.EnsureCreated();
        }
    }
}
