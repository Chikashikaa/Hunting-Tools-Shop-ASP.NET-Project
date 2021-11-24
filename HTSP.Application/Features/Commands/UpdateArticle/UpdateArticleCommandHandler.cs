using HTSP.Application.Features.Exceptions;
using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.UpdateArticle
{
    public class UpdateArticleCommandHandler
        : IRequestHandler<UpdateArticleCommand>
    {
        private readonly IHTSPDbContext _dbContext;
        public UpdateArticleCommandHandler(IHTSPDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Unit> Handle(UpdateArticleCommand ArticleRequest, CancellationToken cancellationToken)
        {
            var article =
                await _dbContext.Articles.FirstOrDefaultAsync(article =>
                    article.ArticleID == ArticleRequest.ArticleID, cancellationToken);
            if (article == null || article.ArticleID != ArticleRequest.ArticleID)
            {
                throw new NotFoundException(nameof(Article), ArticleRequest.ArticleID);
            }

            article.ArticleNaming = ArticleRequest.ArticleNaming;
            article.ArticleType = ArticleRequest.ArticleType;
            article.ArticleMaker = ArticleRequest.ArticleMaker;
            article.ArticlePrice = ArticleRequest.ArticlePrice;
            article.ArticleDescription = ArticleRequest.ArticleDescription;
            article.ArticleImageConnectionStrings = ArticleRequest.ArticleImageConnectionsStrings;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
