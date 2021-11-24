using AutoMapper;
using AutoMapper.QueryableExtensions;
using HTSP.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Queries.ArticleListQuery
{
    public class GetArticleListQueryHandler
    : IRequestHandler<GetArticleListQuery, ArticleListVm>
    {
        private readonly IHTSPDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetArticleListQueryHandler(IHTSPDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);
        public async Task<ArticleListVm> Handle(GetArticleListQuery GetRequest, CancellationToken cancellationToken)
        {
            var article = await _dbContext.Articles
                .Where(article => article.ArticleID == GetRequest.ArticleID)
                .ProjectTo<ArticleListLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new ArticleListVm { Articles = article };
        }
    }
}
