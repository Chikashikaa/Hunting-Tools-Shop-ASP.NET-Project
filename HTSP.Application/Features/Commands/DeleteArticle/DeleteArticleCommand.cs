using MediatR;
using System;

namespace HTSP.Application.Features.Commands.DeleteArticle
{
    public class DeleteArticleCommand : IRequest
    {
        public Guid ArticleID { get; set; }
    }
}
