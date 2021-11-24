using MediatR;
using System;

namespace HTSP.Application.Features.Queries.OrderLineQuery
{
    public class GetOrderLineQuery : IRequest<OrderLineVm>
    {
        public Guid OrderLineID { get; set; }
    }
}
