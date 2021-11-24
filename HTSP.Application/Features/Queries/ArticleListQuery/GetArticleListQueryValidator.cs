using FluentValidation;
using System;

namespace HTSP.Application.Features.Queries.ArticleListQuery
{
    public class GetArticleListQueryValidator : AbstractValidator<GetArticleListQuery>
    {
        public GetArticleListQueryValidator()
        {
            RuleFor(articleList =>
            articleList.ArticleID).NotEqual(Guid.Empty);
        }
    }
}
