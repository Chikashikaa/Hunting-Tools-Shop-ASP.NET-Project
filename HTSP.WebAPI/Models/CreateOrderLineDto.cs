using AutoMapper;
using HTSP.Application.Features.Commands.CreateOrderLine;
using HTSP.Application.Mapping;
using System;

namespace HTSP.WebAPI.Models
{
    public class CreateOrderLineDto : IMapWith<CreateOrderLineCommand>
    {
        public Guid OrderLineID { get; set; }
        public int ArticleNumber { get; set; }
        public Guid OrderID { get; set; }
        public void Mapping(Profile OrderLineProfile)
        {
            OrderLineProfile.CreateMap<CreateOrderLineDto, CreateOrderLineCommand>()
                .ForMember(OrderLineVm => OrderLineVm.OrderLineID, opt => opt.MapFrom(orderline => orderline.OrderLineID))
                .ForMember(OrderLineVm => OrderLineVm.ArticleNumber, opt => opt.MapFrom(orderline => orderline.ArticleNumber))
                .ForMember(OrderLineVm => OrderLineVm.OrderID, opt => opt.MapFrom(order => order.OrderID));
        }
    }
}
