using HTSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HTSP.Interaction.Database_Interaction.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> AccountBuilder)
        {
            AccountBuilder.HasKey(Account => Account.AccountID);
            AccountBuilder.HasIndex(Account => Account.AccountID).IsUnique();
        }
    }
}
