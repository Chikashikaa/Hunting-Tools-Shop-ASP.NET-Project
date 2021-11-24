using MediatR;
using System;

namespace HTSP.Application.Features.Commands.DeleteOrder
{
    public class DeleteOrderCommand : IRequest
    {
        public Guid OrderID { get; set; }
    }
}
