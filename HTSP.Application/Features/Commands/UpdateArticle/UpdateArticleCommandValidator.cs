using FluentValidation;
using System;

namespace HTSP.Application.Features.Commands.UpdateArticle
{
    public class UpdateArticleCommandValidator : AbstractValidator<UpdateArticleCommand>
    {
        public UpdateArticleCommandValidator()
        {
            RuleFor(updateArticleCommand =>
            updateArticleCommand.ArticleNaming).NotEmpty().MaximumLength(100);
            RuleFor(updateArticleCommand =>
            updateArticleCommand.ArticleMaker).NotEmpty().MaximumLength(50);
            RuleFor(updateArticleCommand =>
            updateArticleCommand.ArticleID).NotEqual(Guid.Empty);
            RuleFor(updateArticleCommand =>
            updateArticleCommand.ArticlePrice).NotEmpty();
            RuleFor(updateArticleCommand =>
            updateArticleCommand.ArticleType).NotEmpty().MaximumLength(50);
        }
    }
}
