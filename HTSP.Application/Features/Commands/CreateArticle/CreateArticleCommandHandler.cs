using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.CreateArticle
{
    public class CreateArticleCommandHandler
        : IRequestHandler<CreateArticleCommand, Guid>
    {
        private readonly IHTSPDbContext _dbContext;
        public CreateArticleCommandHandler(IHTSPDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Guid> Handle(CreateArticleCommand ArticleRequest, CancellationToken cancellationToken)
        {
            var article = new Article
            {
                ArticleID = Guid.NewGuid(),
                ArticleNaming = ArticleRequest.ArticleNaming,
                ArticleType = ArticleRequest.ArticleType,
                ArticleMaker = ArticleRequest.ArticleMaker,
                ArticlePrice = ArticleRequest.ArticlePrice,
                ArticleDescription = ArticleRequest.ArticleDescription,
                ArticleImageConnectionStrings = ArticleRequest.ArticleImageConnectionsStrings
            };

            await _dbContext.Articles.AddAsync(article, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return article.ArticleID;
        }
    }
}
