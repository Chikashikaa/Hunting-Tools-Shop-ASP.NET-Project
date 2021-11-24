using HTSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HTSP.Interaction.Database_Interaction.Configuration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> ArticleBuilder)
        {
            ArticleBuilder.HasKey(Article => Article.ArticleID);
            ArticleBuilder.HasIndex(Article => Article.ArticleID).IsUnique();
        }
    }
}
