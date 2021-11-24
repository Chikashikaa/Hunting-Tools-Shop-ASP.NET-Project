using FluentValidation;
using System;

namespace HTSP.Application.Features.Commands.CreateOrderLine
{
    public class CreateOrderLineCommandValidator : AbstractValidator<CreateOrderLineCommand>
    {
        public CreateOrderLineCommandValidator()
        {
            RuleFor(createOrderLineCommand =>
            createOrderLineCommand.OrderLineID).NotEqual(Guid.Empty);
            RuleFor(createOrderLineCommand =>
            createOrderLineCommand.OrderID).NotEqual(Guid.Empty);
            RuleFor(createOrderLineCommand =>
            createOrderLineCommand.ArticleID).NotEmpty();
            RuleFor(createOrderLineCommand =>
            createOrderLineCommand.ArticleNumber).NotEmpty();
        }
    }
}
