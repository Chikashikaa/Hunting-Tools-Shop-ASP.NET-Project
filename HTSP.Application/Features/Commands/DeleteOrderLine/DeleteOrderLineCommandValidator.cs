using FluentValidation;
using System;

namespace HTSP.Application.Features.Commands.DeleteOrderLine
{
    public class DeleteOrderLineCommandValidator : AbstractValidator<DeleteOrderLineCommand>
    {
        public DeleteOrderLineCommandValidator()
        {
            RuleFor(createOrderLineCommand =>
            createOrderLineCommand.OrderLineID).NotEqual(Guid.Empty);
        }
    }
}
