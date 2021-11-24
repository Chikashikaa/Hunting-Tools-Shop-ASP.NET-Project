using MediatR;
using System;

namespace HTSP.Application.Features.Queries.ArticleListQuery
{
    public class GetArticleListQuery : IRequest<ArticleListVm>
    {
        public Guid ArticleID { get; set; }
    }
}
