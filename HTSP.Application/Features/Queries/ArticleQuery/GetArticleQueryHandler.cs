using AutoMapper;
using HTSP.Application.Features.Exceptions;
using HTSP.Application.Interfaces;
using HTSP.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;


namespace HTSP.Application.Features.Queries.ArticleQuery
{
    public class GetArticleQueryHandler
        : IRequestHandler<GetArticleQuery, ArticleVm>
    {
        private readonly IHTSPDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetArticleQueryHandler(IHTSPDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<ArticleVm> Handle(GetArticleQuery GetRequest, CancellationToken cancellationToken)
        {
            var article = await _dbContext.Articles
                .FirstOrDefaultAsync(article => article.ArticleID == GetRequest.ArticleID, cancellationToken);
            if (article == null || article.ArticleID != GetRequest.ArticleID)
            {
                throw new NotFoundException(nameof(Article), GetRequest.ArticleID);
            }
            return _mapper.Map<ArticleVm>(article);
        }
    }
}
