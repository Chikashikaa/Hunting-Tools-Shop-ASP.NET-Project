using System;
using FluentValidation; 

namespace HTSP.Application.Features.Commands.CreateArticle
{
    public class CreateArticleCommandValidator : AbstractValidator<CreateArticleCommand>
    {
        public CreateArticleCommandValidator()
        {
            RuleFor(createArticleCommand => 
            createArticleCommand.ArticleNaming).NotEmpty().MaximumLength(100);
            RuleFor(createArticleCommand =>
            createArticleCommand.ArticleMaker).NotEmpty().MaximumLength(50);
            RuleFor(createArticleCommand => 
            createArticleCommand.ArticleID).NotEqual(Guid.Empty);
            RuleFor(createArticleCommand =>
            createArticleCommand.ArticlePrice).NotEmpty();
            RuleFor(createArticleCommand =>
            createArticleCommand.ArticleType).NotEmpty().MaximumLength(50);
        }
    }
}
