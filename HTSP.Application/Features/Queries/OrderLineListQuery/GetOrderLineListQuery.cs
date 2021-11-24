using MediatR;
using System;

namespace HTSP.Application.Features.Queries.OrderLineListQuery
{
    public class GetOrderLineListQuery : IRequest<OrderLineListVm>
    {
        public Guid OrderLineID { get; set; }
    }
}
