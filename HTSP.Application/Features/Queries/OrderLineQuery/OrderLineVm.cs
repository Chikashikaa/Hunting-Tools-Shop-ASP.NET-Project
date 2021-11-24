using AutoMapper;
using HTSP.Application.Mapping;
using HTSP.Domain.Entities;
using System;

namespace HTSP.Application.Features.Queries.OrderLineQuery
{
    public class OrderLineVm : IMapWith<OrderLine>
    {
        public Guid OrderLineID { get; set; }
        public int ArticleNumber { get; set; }
        public Guid OrderID { get; set; }
        public void Mapping(Profile OrderLineProfile)
        {
            OrderLineProfile.CreateMap<OrderLine, OrderLineVm>()
                .ForMember(OrderLineVm => OrderLineVm.OrderLineID, opt => opt.MapFrom(orderline => orderline.OrderLineID))
                .ForMember(OrderLineVm => OrderLineVm.ArticleNumber, opt => opt.MapFrom(orderline => orderline.ArticleNumber))
                .ForMember(OrderLineVm => OrderLineVm.OrderID, opt => opt.MapFrom(order => order.OrderID));
        }
    }
}