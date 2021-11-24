using MediatR;
using System;
using System.Collections.Generic;

namespace HTSP.Application.Features.Commands.CreateArticle
{
    public class CreateArticleCommand : IRequest<Guid>
    {
        public Guid ArticleID { get; set; }
        public string ArticleNaming { get; set; }
        public string ArticleImageConnectionsStrings { get; set; }
        public string ArticleType { get; set; }
        public string ArticleMaker { get; set; }
        public float ArticlePrice { get; set; }
        public string ArticleDescription { get; set; }
    }
}
