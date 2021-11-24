using HTSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HTSP.Interaction.Database_Interaction.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> OrderBuilder)
        {
            OrderBuilder.HasKey(Order => Order.OrderId);
            OrderBuilder.HasIndex(Order => Order.OrderId).IsUnique();
        }
    }
}
