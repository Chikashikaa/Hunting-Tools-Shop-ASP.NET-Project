using FluentValidation;
using System;

namespace HTSP.Application.Features.Commands.DeleteOrder
{
    public class DeleteOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderCommandValidator()
        {
            RuleFor(deleteOrderCommand =>
            deleteOrderCommand.OrderID).NotEqual(Guid.Empty);
        }
    }
}
