using MediatR;
using System;

namespace HTSP.Application.Features.Queries.OrderQuery
{
    public class GetOrderQuery : IRequest<OrderVm>
    {
        public Guid OrderID { get; set; }
    }
}
