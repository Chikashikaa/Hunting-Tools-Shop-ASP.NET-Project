using MediatR;
using System;

namespace HTSP.Application.Features.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<Guid>
    {
        public Guid OrderId { get; set; }
        public DateTime OrderSetDate { get; set; }
        public DateTime OrderGetDate { get; set; }
        public bool OrderStatus { get; set; }
        public int AccountID { get; set; }
    }
}
