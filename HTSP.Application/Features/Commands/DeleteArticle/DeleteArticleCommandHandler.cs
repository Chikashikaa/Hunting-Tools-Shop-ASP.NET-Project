using HTSP.Application.Features.Exceptions;
using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.DeleteArticle
{
    public class DeleteArticleCommandHandler
    : IRequestHandler<DeleteArticleCommand>
    {
        private readonly IHTSPDbContext _dbContext;
        public DeleteArticleCommandHandler(IHTSPDbContext dbContext) =>
            _dbContext = dbContext;
        public async Task<Unit> Handle(DeleteArticleCommand DeleteRequest, CancellationToken cancellationToken)
        {
            var article =
                await _dbContext.Articles.FindAsync(new object[] { DeleteRequest.ArticleID }, cancellationToken);
            if (article == null || article.ArticleID != DeleteRequest.ArticleID)
            {
                throw new NotFoundException(nameof(Account), DeleteRequest.ArticleID);
            }
            _dbContext.Articles.Remove(article);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
