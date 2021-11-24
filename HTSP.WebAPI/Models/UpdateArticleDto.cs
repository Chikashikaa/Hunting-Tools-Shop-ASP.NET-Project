using AutoMapper;
using HTSP.Application.Features.Commands.UpdateArticle;
using HTSP.Application.Mapping;
using System;
using System.Collections.Generic;

namespace HTSP.WebAPI.Models
{
    public class UpdateArticleDto : IMapWith<UpdateArticleCommand>
    {
        public Guid ArticleID { get; set; }
        public string ArticleNaming { get; set; }
        public string ArticleImageConnectionsStrings { get; set; }
        public string ArticleType { get; set; }
        public string ArticleMaker { get; set; }
        public float ArticlePrice { get; set; }
        public string ArticleDescription { get; set; }
        public void Mapping(Profile ArticleProfile)
        {
            ArticleProfile.CreateMap<UpdateArticleDto, UpdateArticleCommand>()
                .ForMember(ArticleCommand => ArticleCommand.ArticleID, opt => opt.MapFrom(articleDto => articleDto.ArticleID))
                .ForMember(ArticleCommand => ArticleCommand.ArticleNaming, opt => opt.MapFrom(articleDto => articleDto.ArticleNaming))
                .ForMember(ArticleCommand => ArticleCommand.ArticleImageConnectionsStrings, opt => opt.MapFrom(articleDto => articleDto.ArticleImageConnectionsStrings))
                .ForMember(ArticleCommand => ArticleCommand.ArticleType, opt => opt.MapFrom(articleDto => articleDto.ArticleType))
                .ForMember(ArticleCommand => ArticleCommand.ArticleMaker, opt => opt.MapFrom(articleDto => articleDto.ArticleMaker))
                .ForMember(ArticleCommand => ArticleCommand.ArticlePrice, opt => opt.MapFrom(articleDto => articleDto.ArticlePrice))
                .ForMember(ArticleCommand => ArticleCommand.ArticleDescription, opt => opt.MapFrom(articleDto => articleDto.ArticleDescription));
        }
    }
}
