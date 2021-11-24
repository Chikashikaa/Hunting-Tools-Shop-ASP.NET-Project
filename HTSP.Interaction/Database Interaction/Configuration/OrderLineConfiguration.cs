using HTSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HTSP.Interaction.Database_Interaction.Configuration
{
    public class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> OrderLineBuilder)
        {
            OrderLineBuilder.HasKey(OrderLine => OrderLine.OrderLineID);
            OrderLineBuilder.HasIndex(OrderLine => OrderLine.OrderLineID).IsUnique();
        }
    }
}
