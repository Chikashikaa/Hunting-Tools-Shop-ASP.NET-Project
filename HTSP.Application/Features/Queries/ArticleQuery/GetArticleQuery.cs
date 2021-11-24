using MediatR;
using System;

namespace HTSP.Application.Features.Queries.ArticleQuery
{
    public class GetArticleQuery : IRequest<ArticleVm>
    {
        public Guid ArticleID { get; set; }
    }
}
