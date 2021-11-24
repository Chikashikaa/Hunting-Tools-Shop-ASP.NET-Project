using FluentValidation;
using System;

namespace HTSP.Application.Features.Queries.ArticleQuery
{
    public class GetArticleQueryValidator : AbstractValidator<GetArticleQuery>
    {
        public GetArticleQueryValidator()
        {
            RuleFor(article =>
            article.ArticleID).NotEqual(Guid.Empty);
        }
    }
}
