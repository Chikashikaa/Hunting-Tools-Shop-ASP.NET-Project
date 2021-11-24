using MediatR;
using System;

namespace HTSP.Application.Features.Queries.OrderListQuery
{
    public class GetOrderListQuery : IRequest<OrderListVm>
    {
        public Guid OrderID { get; set; }
    }
}
