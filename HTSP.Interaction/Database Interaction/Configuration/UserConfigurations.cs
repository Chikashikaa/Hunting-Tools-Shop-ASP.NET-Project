using HTSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HTSP.Interaction.Database_Interaction.Configuration
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> UserBuilder)
        {
            UserBuilder.HasKey(User => User.UserID);
            UserBuilder.HasIndex(User => User.UserID).IsUnique();
            UserBuilder.Property(User => User.UserName).HasMaxLength(40);
            UserBuilder.Property(User => User.UserLastName).HasMaxLength(100);
            UserBuilder.Property(User => User.UserPhoneNumber).HasMaxLength(15);
        }
    }
}
