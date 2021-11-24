using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTSP.Application.Features.Commands.DeleteArticle
{
    public class DeleteArticleCommandValidator : AbstractValidator<DeleteArticleCommand>
    {
        public DeleteArticleCommandValidator()
        {
            RuleFor(deleteArticleCommand =>
            deleteArticleCommand.ArticleID).NotEqual(Guid.Empty);
        }
    }
}
