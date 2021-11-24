using MediatR;
using System;

namespace HTSP.Application.Features.Commands.CreateOrderLine
{
    public class CreateOrderLineCommand : IRequest<Guid>
    {
        public Guid OrderLineID { get; set; }
        public int ArticleNumber { get; set; }
        public int ArticleID { get; set; }
        public Guid OrderID { get; set; }
    }
}
