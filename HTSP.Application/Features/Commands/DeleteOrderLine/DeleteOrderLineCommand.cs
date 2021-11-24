using MediatR;
using System;

namespace HTSP.Application.Features.Commands.DeleteOrderLine
{
    public class DeleteOrderLineCommand : IRequest
    {
        public Guid OrderLineID { get; set; }
    }
}
