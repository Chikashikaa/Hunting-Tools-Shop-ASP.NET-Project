using AutoMapper;
using HTSP.Application.Mapping;
using HTSP.Domain.Entities;
using System;
using System.Collections.Generic;

namespace HTSP.Application.Features.Queries.ArticleQuery
{
    public class ArticleVm : IMapWith<Article>
    {
        public Guid ArticleID { get; set; }
        public string ArticleNaming { get; set; }
        public string ArticleImageConnectionStrings { get; set; }
        public string ArticleType { get; set; }
        public string ArticleMaker { get; set; }
        public float ArticlePrice { get; set; }
        public string ArticleDescription { get; set; }
        public void Mapping(Profile ArticleProfile)
        {
            ArticleProfile.CreateMap<Article, ArticleVm>()
                .ForMember(ArticleVm => ArticleVm.ArticleID, opt => opt.MapFrom(article => article.ArticleID))
                .ForMember(ArticleVm => ArticleVm.ArticleNaming, opt => opt.MapFrom(article => article.ArticleNaming))
                .ForMember(ArticleVm => ArticleVm.ArticleImageConnectionStrings, opt => opt.MapFrom(article => article.ArticleImageConnectionStrings))
                .ForMember(ArticleVm => ArticleVm.ArticleType, opt => opt.MapFrom(article => article.ArticleType))
                .ForMember(ArticleVm => ArticleVm.ArticlePrice, opt => opt.MapFrom(article => article.ArticlePrice))
                .ForMember(ArticleVm => ArticleVm.ArticleDescription, opt => opt.MapFrom(article => article.ArticleDescription))
                .ForMember(ArticleVm => ArticleVm.ArticleMaker, opt => opt.MapFrom(article => article.ArticleMaker));
        }
    }
}
