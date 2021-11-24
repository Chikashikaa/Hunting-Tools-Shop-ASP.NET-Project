using AutoMapper;
using HTSP.Application.Mapping;
using HTSP.Domain.Entities;
using System;

namespace HTSP.Application.Features.Queries.OrderQuery
{
    public class OrderVm : IMapWith<Order>
    {
        public Guid OrderId { get; set; }
        public DateTime OrderSetDate { get; set; }
        public DateTime OrderGetDate { get; set; }
        public bool OrderStatus { get; set; }

        public void Mapping(Profile OrderProfile)
        {
            OrderProfile.CreateMap<Order, OrderVm>()
                .ForMember(OrderVm => OrderVm.OrderId, opt => opt.MapFrom(order => order.OrderId))
                .ForMember(OrderVm => OrderVm.OrderGetDate, opt => opt.MapFrom(order => order.OrderGetDate))
                .ForMember(OrderVm => OrderVm.OrderSetDate, opt => opt.MapFrom(order => order.OrderSetDate))
                .ForMember(OrderVm => OrderVm.OrderStatus, opt => opt.MapFrom(order => order.OrderStatus));
        }
    }
}