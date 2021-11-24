using AutoMapper;
using HTSP.Application.Features.Commands.CreateOrder;
using HTSP.Application.Mapping;
using System;

namespace HTSP.WebAPI.Models
{
    public class CreateOrderDto : IMapWith<CreateOrderCommand>
    {
        public DateTime OrderSetDate { get; set; }
        public DateTime OrderGetDate { get; set; }
        public bool OrderStatus { get; set; }

        public void Mapping(Profile OrderProfile)
        {
            OrderProfile.CreateMap<CreateOrderDto, CreateOrderCommand>()
                .ForMember(OrderVm => OrderVm.OrderGetDate, opt => opt.MapFrom(order => order.OrderGetDate))
                .ForMember(OrderVm => OrderVm.OrderSetDate, opt => opt.MapFrom(order => order.OrderSetDate))
                .ForMember(OrderVm => OrderVm.OrderStatus, opt => opt.MapFrom(order => order.OrderStatus));
        }
    }
}
