using AutoMapper;
using HTSP.Application.Mapping;
using HTSP.Domain.Entities;
using System;

namespace HTSP.Application.Features.Queries.ArticleListQuery
{
    public class ArticleListLookupDto : IMapWith<Article>
    {
        public Guid ArticleID { get; set; }
        public string ArticleNaming { get; set; }
        public string ArticleType { get; set; }
        public float ArticlePrice { get; set; }
        public void Mapping(Profile ArticleProfile)
        {
            ArticleProfile.CreateMap<Article, ArticleListLookupDto>()
                .ForMember(ArticleVm => ArticleVm.ArticleID, opt => opt.MapFrom(article => article.ArticleID))
                .ForMember(ArticleVm => ArticleVm.ArticleNaming, opt => opt.MapFrom(article => article.ArticleNaming))
                .ForMember(ArticleVm => ArticleVm.ArticlePrice, opt => opt.MapFrom(article => article.ArticlePrice))
                .ForMember(ArticleVm => ArticleVm.ArticleType, opt => opt.MapFrom(article => article.ArticleType));
        }
    }
}
